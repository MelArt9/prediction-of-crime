using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.ML;
using PredictionOfCrime.Service;
using PredictionOfCrime.DataAccess;
using System.Text;
using System.Collections.Generic;

namespace PredictionOfCrime
{
    public partial class PredictionForm : Form
    {
        private MLContext _mlContext;
        private ModelTrainer _modelTrainer;

        private string loadedCsvFilePath;
        private ITransformer loadedModel;
        private ITransformer currentModel;
        private string currentModelPath;

        public PredictionForm()
        {
            InitializeComponent();

            _mlContext = new MLContext();
            _modelTrainer = new ModelTrainer(_mlContext);
            btnRePlay.Visible = false;

            // Назначение обработчиков событий для радиобаттонов
            rbFileWithData.CheckedChanged += new EventHandler(rbFileWithData_CheckedChanged);
            rbTrainModel.CheckedChanged += new EventHandler(rbTrainModel_CheckedChanged);

            // Начальное состояние групповых полей
            UpdateGroupBoxVisibility();
        }

        // Настройка RadioButton

        private void UpdateGroupBoxVisibility()
        {
            gbFileWithData.Visible = rbFileWithData.Checked;
            gbTrainModel.Visible = rbTrainModel.Checked;
        }

        private void rbFileWithData_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGroupBoxVisibility();
        }

        private void rbTrainModel_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGroupBoxVisibility();
        }

        // Страница Trainer

        // Загрузка обученной модели

        private void btnDownloadModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "ZIP files (*.zip)|*.zip",
                Title = "Выберите файл модели"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string modelPath = openFileDialog.FileName;
                try
                {
                    MLContext mlContext = new MLContext();
                    using (var stream = new FileStream(modelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        loadedModel = mlContext.Model.Load(stream, out var modelInputSchema);
                    }

                    gbMethods.Enabled = false;

                    txtPath.Text = modelPath;
                    currentModel = loadedModel;
                    currentModelPath = modelPath;

                    txtPath.Enabled = false;
                    gbTrainModel.Enabled = false;
                    btnRePlay.Visible = true;

                    MessageBox.Show("Модель успешно загружена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить модель: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Загрузка файла csv с данными для дальнейшего обучения модели

        private DataTable LoadCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dataTable.Rows.Add(dr);
                }
            }
            dgwData.DataSource = dataTable;

            return dataTable;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выберите CSV-файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedCsvFilePath = openFileDialog.FileName;
                try
                {
                    DataTable dataTable = LoadCsvToDataGridView(loadedCsvFilePath);
                    dgwData.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить CSV-файл: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadedCsvFilePath = string.Empty;
                }
            }

            currentModel = loadedModel;
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedCsvFilePath))
            {
                MessageBox.Show("Пожалуйста, сначала загрузите CSV-файл.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MLContext mlContext = new MLContext();
            ModelTrainer trainer = new ModelTrainer(mlContext);

            try
            {
                ITransformer trainedModel = trainer.TrainModel(loadedCsvFilePath, null);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "ZIP files (*.zip)|*.zip",
                    Title = "Сохранение обученной модели"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentModelPath = saveFileDialog.FileName;
                    trainer.SaveModel(currentModelPath);
                    MessageBox.Show("Модель была обучена и успешно сохранена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                currentModel = trainedModel;

                gbMethods.Enabled = false;
                btnRePlay.Visible = true;
                gbFileWithData.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Обучение модели завершилось неудачей: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка для активации панели с выбором способа тренировки модели
        private void btnRePlay_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите деактивировать текущую модель и активировать панель для новых действий?",
                                                "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                loadedModel = null;
                currentModel = loadedModel;

                gbMethods.Enabled = true;
                gbTrainModel.Enabled = true;
                gbFileWithData.Enabled = true;
                btnRePlay.Visible = false;

                dgwData.DataSource = null;
                txtPath.Text = string.Empty;

                MessageBox.Show("Теперь вы можете создать новую модель или загрузить существующую.", "Panel Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Тестирование модели

        private void btnTest_Click(object sender, EventArgs e)
        {
            listMetrics.Items.Clear();

            if (currentModel == null)
            {
                MessageBox.Show("Пожалуйста, сначала загрузите модель.", "Model Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выберите CSV-файл для тестирования модели"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string testDataPath = openFileDialog.FileName;

                try
                {
                    IDataView testData = _mlContext.Data.LoadFromTextFile<CrimeData>(testDataPath, hasHeader: true, separatorChar: ',');

                    ModelTester tester = new ModelTester(_mlContext, currentModel);
                    var metrics = tester.TestModel(testData);

                    listMetrics.Items.Clear();
                    listMetrics.Items.Add($"Macro accuracy: {metrics.MacroAccuracy:P2}");
                    listMetrics.Items.Add($"Micro accuracy: {metrics.MicroAccuracy:P2}");
                    listMetrics.Items.Add($"Log Loss: {metrics.LogLoss}");
                    listMetrics.Items.Add($"Log Loss Reduction: {metrics.LogLossReduction}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка тестирования модели: {ex.Message}", "Test Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Переобучение модели новыми данными

        private void btnDownloadReTrainer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выбор CSV-файл для повторного обучения"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedCsvFilePath = openFileDialog.FileName;
                try
                {
                    DataTable dataTable = LoadCsvToDataGridView(loadedCsvFilePath);
                    dgvReTrain.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить CSV-файл: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadedCsvFilePath = string.Empty;
                }
            }
        }

        private void btnReTrain_Click(object sender, EventArgs e)
        {
            if (currentModel == null)
            {
                MessageBox.Show("Пожалуйста, сначала загрузите модель.", "Model Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvReTrain.DataSource == null)
            {
                MessageBox.Show("Пожалуйста, загрузите обучающие данные.", "Training Data Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ModelReTrainer reTrainer = new ModelReTrainer(_mlContext, currentModel);
                reTrainer.ReTrainModel(loadedCsvFilePath);

                var result = MessageBox.Show("Вы хотите сохранить переобученную модель под новым именем?", "Save Retrained Model",
                                             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "ZIP files (*.zip)|*.zip",
                        Title = "Сохрание переобученной модели"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        reTrainer.SaveModel(saveFileDialog.FileName);
                        MessageBox.Show("Модель была успешно сохраненена!", "Re-training Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.No)
                {
                    if (!string.IsNullOrEmpty(currentModelPath))
                    {
                        reTrainer.SaveModel(currentModelPath);
                        MessageBox.Show("Модель была сохранена, а существующая модель была перезаписана.", "Re-training Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Путь для сохранения модели недоступен.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось переобучить модель: {ex.Message}", "Re-training Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Прогнозирование модели типа преступления по введенным данным

        private void btnForecast_Click(object sender, EventArgs e)
        {
            textBoxPredictionResult.Text = "";

            if (currentModel == null)
            {
                MessageBox.Show("Пожалуйста, сначала обучите или загрузите модель.", "Model Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что хотя бы одно поле заполнено
            if (string.IsNullOrWhiteSpace(datePicker.Text) &&
                string.IsNullOrWhiteSpace(timePicker.Text) &&
                comboBoxLocation.SelectedItem == null &&
                comboBoxVictimGender.SelectedItem == null &&
                comboBoxPerpetratorGender.SelectedItem == null &&
                comboBoxWeapon.SelectedItem == null &&
                comboBoxInjury.SelectedItem == null &&
                comboBoxWeather.SelectedItem == null &&
                string.IsNullOrWhiteSpace(numericUpDownLatitude.Text) &&
                string.IsNullOrWhiteSpace(numericUpDownLongitude.Text) &&
                string.IsNullOrWhiteSpace(numericUpDownVictimAge.Text) &&
                string.IsNullOrWhiteSpace(numericUpDownPerpetratorAge.Text) &&
                string.IsNullOrWhiteSpace(numericUpDownTemperature.Text) &&
                comboBoxPreviousActivity.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, предоставьте хотя бы один ввод для прогнозирования.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем объект CrimeData и заполняем только заполненные поля
            CrimeData input = new CrimeData
            {
                Date = datePicker.Value.Date.ToString("dd.MM.yyyy"),
                TimeOfDay = timePicker.Value.TimeOfDay.ToString(),
                Location = comboBoxLocation.SelectedItem?.ToString(),
                Latitude = float.TryParse(numericUpDownLatitude.Text, out float latitude) ? latitude : 0f,
                Longitude = float.TryParse(numericUpDownLongitude.Text, out float longitude) ? longitude : 0f,
                VictimGender = comboBoxVictimGender.SelectedItem?.ToString(),
                VictimAge = float.TryParse(numericUpDownVictimAge.Text, out float victimAge) ? victimAge : 0f,
                PerpetratorGender = comboBoxPerpetratorGender.SelectedItem?.ToString(),
                PerpetratorAge = float.TryParse(numericUpDownPerpetratorAge.Text, out float perpetratorAge) ? perpetratorAge : 0f,
                Weapon = comboBoxWeapon.SelectedItem?.ToString(),
                Injury = comboBoxInjury.SelectedItem?.ToString(),
                Weather = comboBoxWeather.SelectedItem?.ToString(),
                Temperature = float.TryParse(numericUpDownTemperature.Text, out float temperature) ? temperature : 0f,
                PreviousActivity = comboBoxPreviousActivity.SelectedItem?.ToString()
            };

            var predictionEngine = _mlContext.Model.CreatePredictionEngine<CrimeData, PredictionCrime>(currentModel);
            var prediction = predictionEngine.Predict(input);

            string crimeTypeInEnglish = prediction.PredictedCrimeType;

            // Получаем русский перевод из словаря
            string crimeTypeInRussian = crimeTypeTranslations.ContainsKey(crimeTypeInEnglish)
                                        ? crimeTypeTranslations[crimeTypeInEnglish]
                                        : "Неизвестное преступление";

            textBoxPredictionResult.Text = $"{crimeTypeInEnglish} ({crimeTypeInRussian})";
        }

        private Dictionary<string, string> crimeTypeTranslations = new Dictionary<string, string>
        {
            {"Theft", "Кража/Ограбление"},
            {"Burglary", "Кража со взломом"},
            {"Assault", "Нападение"},
            {"Embezzlement", "Хищение"},
            {"Robbery", "Разбой/Грабёж"},
            {"Vandalism", "Вандализм"},
            {"Drug Offense", "Преступление, связанное с наркотиками"},
            {"Forgery", "Фальсификация"},
            {"Fraud", "Мошенничество"}
        };

        // Кнопка «Сохранить тестовые данные»
        private void btnSaveTestData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Сохранение тестовых данных"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvContent = new StringBuilder();
                csvContent.AppendLine("date,time_of_day,location,latitude,longitude,victim_gender,victim_age,perpetrator_gender,perpetrator_age,weapon,injury,weather,temperature,previous_activity");

                // Использование инвариантной культуры для форматирования чисел
                var cultureInfo = System.Globalization.CultureInfo.InvariantCulture;
                string latitude = numericUpDownLatitude.Value.ToString(cultureInfo);
                string longitude = numericUpDownLongitude.Value.ToString(cultureInfo);

                csvContent.AppendLine($"{datePicker.Value.ToString("dd.MM.yyyy")},{timePicker.Value.ToString("HH:mm:ss")},{GetComboBoxValue(comboBoxLocation)},{latitude},{longitude},{GetComboBoxValue(comboBoxVictimGender)},{numericUpDownVictimAge.Value.ToString(cultureInfo)},{GetComboBoxValue(comboBoxPerpetratorGender)},{numericUpDownPerpetratorAge.Value.ToString(cultureInfo)},{GetComboBoxValue(comboBoxWeapon)},{GetComboBoxValue(comboBoxInjury)},{GetComboBoxValue(comboBoxWeather)},{numericUpDownTemperature.Value.ToString(cultureInfo)},{GetComboBoxValue(comboBoxPreviousActivity)}");

                File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
            }
        }

        private string GetComboBoxValue(ComboBox comboBox)
        {
            return comboBox.SelectedIndex >= 0 ? comboBox.SelectedItem.ToString() : "";
        }

        // Кнопка «Загрузить тестовые данные»
        private void btnOpenTestData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Загрузка тестовых данных"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Чтение данных из CSV файла и заполнение полей формы
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                if (lines.Length > 1) // Проверяем, есть ли данные помимо заголовка
                {
                    string[] data = lines[1].Split(','); // Берем первую строку данных
                    if (data.Length == 14) // Убедимся, что в строке 14 элементов
                    {
                        // Предполагаем, что поля сопоставляются непосредственно с порядком в CSV
                        datePicker.Value = DateTime.Parse(data[0]);
                        timePicker.Value = DateTime.Parse(data[1]);
                        SetComboBoxValue(comboBoxLocation, data[2]);
                        
                        var cultureInfo = System.Globalization.CultureInfo.InvariantCulture;
                        numericUpDownLatitude.Value = Convert.ToDecimal(data[3], cultureInfo);
                        numericUpDownLongitude.Value = Convert.ToDecimal(data[4], cultureInfo);

                        SetComboBoxValue(comboBoxVictimGender, data[5]);
                        numericUpDownVictimAge.Value = Convert.ToDecimal(data[6]);
                        SetComboBoxValue(comboBoxPerpetratorGender, data[7]);
                        numericUpDownPerpetratorAge.Value = Convert.ToDecimal(data[8]);
                        SetComboBoxValue(comboBoxWeapon, data[9]);
                        SetComboBoxValue(comboBoxInjury, data[10]);
                        SetComboBoxValue(comboBoxWeather, data[11]);
                        numericUpDownTemperature.Value = Convert.ToDecimal(data[12]);
                        SetComboBoxValue(comboBoxPreviousActivity, data[13]);
                    }
                    else
                    {
                        MessageBox.Show("Формат данных в CSV файле не соответствует ожидаемому.", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetComboBoxValue(ComboBox comboBox, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                comboBox.SelectedIndex = -1; // Сброс, если значение пустое
            }
            else
            {
                comboBox.SelectedItem = value; // Иначе устанавливаем выбранное значение
            }
        }

        private void btnClearPrediction_Click(object sender, EventArgs e)
        {
            // Очистка текстовых полей и полей с числовыми значениями
            textBoxPredictionResult.Text = "";
            numericUpDownLatitude.Value = numericUpDownLatitude.Minimum;
            numericUpDownLongitude.Value = numericUpDownLongitude.Minimum;
            numericUpDownVictimAge.Value = numericUpDownVictimAge.Minimum;
            numericUpDownPerpetratorAge.Value = numericUpDownPerpetratorAge.Minimum;
            numericUpDownTemperature.Value = numericUpDownTemperature.Minimum;

            // Сброс выбранных значений в ComboBox и DateTimePicker
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            comboBoxLocation.SelectedIndex = -1;
            comboBoxVictimGender.SelectedIndex = -1;
            comboBoxPerpetratorGender.SelectedIndex = -1;
            comboBoxWeapon.SelectedIndex = -1;
            comboBoxInjury.SelectedIndex = -1;
            comboBoxWeather.SelectedIndex = -1;
            comboBoxPreviousActivity.SelectedIndex = -1;
        }

        private void btnClearReTrainer_Click(object sender, EventArgs e)
        {
            dgvReTrain.DataSource = null;
        }
    }
}