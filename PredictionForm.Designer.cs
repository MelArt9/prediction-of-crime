namespace PredictionOfCrime
{
    partial class PredictionForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRePlay = new System.Windows.Forms.Button();
            this.gbMethods = new System.Windows.Forms.GroupBox();
            this.rbTrainModel = new System.Windows.Forms.RadioButton();
            this.rbFileWithData = new System.Windows.Forms.RadioButton();
            this.gbFileWithData = new System.Windows.Forms.GroupBox();
            this.btnTeach = new System.Windows.Forms.Button();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbTrainModel = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDownloadModel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listMetrics = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.REgbFileWithData = new System.Windows.Forms.GroupBox();
            this.btnClearReTrainer = new System.Windows.Forms.Button();
            this.btnReTrainer = new System.Windows.Forms.Button();
            this.dgvReTrain = new System.Windows.Forms.DataGridView();
            this.btnDownloadReTrainer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearPrediction = new System.Windows.Forms.Button();
            this.btnSaveTestData = new System.Windows.Forms.Button();
            this.btnOpenTestData = new System.Windows.Forms.Button();
            this.PgbTypePrediction = new System.Windows.Forms.GroupBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxPreviousActivity = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxWeather = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxInjury = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.numericUpDownLatitude = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDownLongitude = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPerpetratorAge = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPerpetratorGender = new System.Windows.Forms.ComboBox();
            this.comboBoxVictimGender = new System.Windows.Forms.ComboBox();
            this.numericUpDownVictimAge = new System.Windows.Forms.NumericUpDown();
            this.PgbForecast = new System.Windows.Forms.GroupBox();
            this.textBoxPredictionResult = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbMethods.SuspendLayout();
            this.gbFileWithData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.gbTrainModel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.REgbFileWithData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReTrain)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.PgbTypePrediction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerpetratorAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVictimAge)).BeginInit();
            this.PgbForecast.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRePlay);
            this.tabPage1.Controls.Add(this.gbMethods);
            this.tabPage1.Controls.Add(this.gbTrainModel);
            this.tabPage1.Controls.Add(this.gbFileWithData);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRePlay
            // 
            this.btnRePlay.Location = new System.Drawing.Point(54, 106);
            this.btnRePlay.Name = "btnRePlay";
            this.btnRePlay.Size = new System.Drawing.Size(132, 59);
            this.btnRePlay.TabIndex = 34;
            this.btnRePlay.Text = "Активировать панель";
            this.btnRePlay.UseVisualStyleBackColor = true;
            this.btnRePlay.Click += new System.EventHandler(this.btnRePlay_Click);
            // 
            // gbMethods
            // 
            this.gbMethods.Controls.Add(this.rbTrainModel);
            this.gbMethods.Controls.Add(this.rbFileWithData);
            this.gbMethods.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMethods.Location = new System.Drawing.Point(8, 6);
            this.gbMethods.Name = "gbMethods";
            this.gbMethods.Size = new System.Drawing.Size(233, 83);
            this.gbMethods.TabIndex = 16;
            this.gbMethods.TabStop = false;
            this.gbMethods.Text = "Способы:";
            // 
            // rbTrainModel
            // 
            this.rbTrainModel.AutoSize = true;
            this.rbTrainModel.Location = new System.Drawing.Point(6, 52);
            this.rbTrainModel.Name = "rbTrainModel";
            this.rbTrainModel.Size = new System.Drawing.Size(206, 22);
            this.rbTrainModel.TabIndex = 19;
            this.rbTrainModel.TabStop = true;
            this.rbTrainModel.Text = "Загрузка обученной модели";
            this.rbTrainModel.UseVisualStyleBackColor = true;
            this.rbTrainModel.CheckedChanged += new System.EventHandler(this.rbTrainModel_CheckedChanged);
            // 
            // rbFileWithData
            // 
            this.rbFileWithData.AutoSize = true;
            this.rbFileWithData.Location = new System.Drawing.Point(6, 25);
            this.rbFileWithData.Name = "rbFileWithData";
            this.rbFileWithData.Size = new System.Drawing.Size(200, 22);
            this.rbFileWithData.TabIndex = 21;
            this.rbFileWithData.TabStop = true;
            this.rbFileWithData.Text = "Загрузка файла с данными";
            this.rbFileWithData.UseVisualStyleBackColor = true;
            this.rbFileWithData.CheckedChanged += new System.EventHandler(this.rbFileWithData_CheckedChanged);
            // 
            // gbFileWithData
            // 
            this.gbFileWithData.Controls.Add(this.btnTeach);
            this.gbFileWithData.Controls.Add(this.dgwData);
            this.gbFileWithData.Controls.Add(this.button2);
            this.gbFileWithData.Controls.Add(this.btnDownload);
            this.gbFileWithData.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFileWithData.Location = new System.Drawing.Point(247, 6);
            this.gbFileWithData.Name = "gbFileWithData";
            this.gbFileWithData.Size = new System.Drawing.Size(570, 547);
            this.gbFileWithData.TabIndex = 18;
            this.gbFileWithData.TabStop = false;
            this.gbFileWithData.Text = "Файл данных:";
            // 
            // btnTeach
            // 
            this.btnTeach.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeach.Location = new System.Drawing.Point(233, 495);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(125, 40);
            this.btnTeach.TabIndex = 33;
            this.btnTeach.Text = "Обучить";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // dgwData
            // 
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(6, 77);
            this.dgwData.Name = "dgwData";
            this.dgwData.ReadOnly = true;
            this.dgwData.RowHeadersWidth = 51;
            this.dgwData.RowTemplate.Height = 24;
            this.dgwData.Size = new System.Drawing.Size(558, 412);
            this.dgwData.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обучить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownload.Location = new System.Drawing.Point(232, 27);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(125, 40);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Загрузить";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // gbTrainModel
            // 
            this.gbTrainModel.Controls.Add(this.txtPath);
            this.gbTrainModel.Controls.Add(this.btnDownloadModel);
            this.gbTrainModel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrainModel.Location = new System.Drawing.Point(241, 4);
            this.gbTrainModel.Name = "gbTrainModel";
            this.gbTrainModel.Size = new System.Drawing.Size(587, 204);
            this.gbTrainModel.TabIndex = 19;
            this.gbTrainModel.TabStop = false;
            this.gbTrainModel.Text = "Обученная модель:";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.Location = new System.Drawing.Point(32, 119);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(505, 41);
            this.txtPath.TabIndex = 4;
            // 
            // btnDownloadModel
            // 
            this.btnDownloadModel.Location = new System.Drawing.Point(245, 45);
            this.btnDownloadModel.Name = "btnDownloadModel";
            this.btnDownloadModel.Size = new System.Drawing.Size(125, 40);
            this.btnDownloadModel.TabIndex = 3;
            this.btnDownloadModel.Text = "Загрузить";
            this.btnDownloadModel.UseVisualStyleBackColor = true;
            this.btnDownloadModel.Click += new System.EventHandler(this.btnDownloadModel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listMetrics);
            this.tabPage2.Controls.Add(this.btnTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тестирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listMetrics
            // 
            this.listMetrics.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listMetrics.FormattingEnabled = true;
            this.listMetrics.ItemHeight = 24;
            this.listMetrics.Location = new System.Drawing.Point(218, 232);
            this.listMetrics.Name = "listMetrics";
            this.listMetrics.Size = new System.Drawing.Size(382, 220);
            this.listMetrics.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest.Location = new System.Drawing.Point(330, 125);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(172, 63);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Протестировать модель";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.REgbFileWithData);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(836, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Переобучение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // REgbFileWithData
            // 
            this.REgbFileWithData.Controls.Add(this.btnClearReTrainer);
            this.REgbFileWithData.Controls.Add(this.btnReTrainer);
            this.REgbFileWithData.Controls.Add(this.dgvReTrain);
            this.REgbFileWithData.Controls.Add(this.btnDownloadReTrainer);
            this.REgbFileWithData.Location = new System.Drawing.Point(8, 6);
            this.REgbFileWithData.Name = "REgbFileWithData";
            this.REgbFileWithData.Size = new System.Drawing.Size(804, 547);
            this.REgbFileWithData.TabIndex = 21;
            this.REgbFileWithData.TabStop = false;
            this.REgbFileWithData.Text = "Файл данных:";
            // 
            // btnClearReTrainer
            // 
            this.btnClearReTrainer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearReTrainer.Location = new System.Drawing.Point(419, 27);
            this.btnClearReTrainer.Name = "btnClearReTrainer";
            this.btnClearReTrainer.Size = new System.Drawing.Size(125, 40);
            this.btnClearReTrainer.TabIndex = 34;
            this.btnClearReTrainer.Text = "Очистить";
            this.btnClearReTrainer.UseVisualStyleBackColor = true;
            this.btnClearReTrainer.Click += new System.EventHandler(this.btnClearReTrainer_Click);
            // 
            // btnReTrainer
            // 
            this.btnReTrainer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReTrainer.Location = new System.Drawing.Point(339, 496);
            this.btnReTrainer.Name = "btnReTrainer";
            this.btnReTrainer.Size = new System.Drawing.Size(151, 40);
            this.btnReTrainer.TabIndex = 33;
            this.btnReTrainer.Text = "Переобучить";
            this.btnReTrainer.UseVisualStyleBackColor = true;
            this.btnReTrainer.Click += new System.EventHandler(this.btnReTrain_Click);
            // 
            // dgvReTrain
            // 
            this.dgvReTrain.AllowUserToAddRows = false;
            this.dgvReTrain.AllowUserToDeleteRows = false;
            this.dgvReTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReTrain.Location = new System.Drawing.Point(128, 78);
            this.dgvReTrain.Name = "dgvReTrain";
            this.dgvReTrain.ReadOnly = true;
            this.dgvReTrain.RowHeadersWidth = 51;
            this.dgvReTrain.RowTemplate.Height = 24;
            this.dgvReTrain.Size = new System.Drawing.Size(558, 412);
            this.dgvReTrain.TabIndex = 3;
            // 
            // btnDownloadReTrainer
            // 
            this.btnDownloadReTrainer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownloadReTrainer.Location = new System.Drawing.Point(273, 27);
            this.btnDownloadReTrainer.Name = "btnDownloadReTrainer";
            this.btnDownloadReTrainer.Size = new System.Drawing.Size(125, 40);
            this.btnDownloadReTrainer.TabIndex = 0;
            this.btnDownloadReTrainer.Text = "Загрузить";
            this.btnDownloadReTrainer.UseVisualStyleBackColor = true;
            this.btnDownloadReTrainer.Click += new System.EventHandler(this.btnDownloadReTrainer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearPrediction);
            this.tabPage4.Controls.Add(this.btnSaveTestData);
            this.tabPage4.Controls.Add(this.btnOpenTestData);
            this.tabPage4.Controls.Add(this.PgbTypePrediction);
            this.tabPage4.Controls.Add(this.PgbForecast);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(836, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Прогнозирование";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearPrediction
            // 
            this.btnClearPrediction.Location = new System.Drawing.Point(6, 230);
            this.btnClearPrediction.Name = "btnClearPrediction";
            this.btnClearPrediction.Size = new System.Drawing.Size(129, 42);
            this.btnClearPrediction.TabIndex = 28;
            this.btnClearPrediction.Text = "Очистить";
            this.btnClearPrediction.UseVisualStyleBackColor = true;
            this.btnClearPrediction.Click += new System.EventHandler(this.btnClearPrediction_Click);
            // 
            // btnSaveTestData
            // 
            this.btnSaveTestData.Location = new System.Drawing.Point(6, 126);
            this.btnSaveTestData.Name = "btnSaveTestData";
            this.btnSaveTestData.Size = new System.Drawing.Size(129, 98);
            this.btnSaveTestData.TabIndex = 27;
            this.btnSaveTestData.Text = "Сохранить тестовые данные";
            this.btnSaveTestData.UseVisualStyleBackColor = true;
            this.btnSaveTestData.Click += new System.EventHandler(this.btnSaveTestData_Click);
            // 
            // btnOpenTestData
            // 
            this.btnOpenTestData.Location = new System.Drawing.Point(6, 22);
            this.btnOpenTestData.Name = "btnOpenTestData";
            this.btnOpenTestData.Size = new System.Drawing.Size(129, 98);
            this.btnOpenTestData.TabIndex = 26;
            this.btnOpenTestData.Text = "Загрузить тестовые данные";
            this.btnOpenTestData.UseVisualStyleBackColor = true;
            this.btnOpenTestData.Click += new System.EventHandler(this.btnOpenTestData_Click);
            // 
            // PgbTypePrediction
            // 
            this.PgbTypePrediction.Controls.Add(this.btnForecast);
            this.PgbTypePrediction.Controls.Add(this.label16);
            this.PgbTypePrediction.Controls.Add(this.label17);
            this.PgbTypePrediction.Controls.Add(this.datePicker);
            this.PgbTypePrediction.Controls.Add(this.label18);
            this.PgbTypePrediction.Controls.Add(this.comboBoxPreviousActivity);
            this.PgbTypePrediction.Controls.Add(this.label19);
            this.PgbTypePrediction.Controls.Add(this.label20);
            this.PgbTypePrediction.Controls.Add(this.numericUpDownTemperature);
            this.PgbTypePrediction.Controls.Add(this.timePicker);
            this.PgbTypePrediction.Controls.Add(this.label21);
            this.PgbTypePrediction.Controls.Add(this.label22);
            this.PgbTypePrediction.Controls.Add(this.label23);
            this.PgbTypePrediction.Controls.Add(this.comboBoxLocation);
            this.PgbTypePrediction.Controls.Add(this.label24);
            this.PgbTypePrediction.Controls.Add(this.comboBoxWeather);
            this.PgbTypePrediction.Controls.Add(this.label26);
            this.PgbTypePrediction.Controls.Add(this.comboBoxInjury);
            this.PgbTypePrediction.Controls.Add(this.label27);
            this.PgbTypePrediction.Controls.Add(this.label28);
            this.PgbTypePrediction.Controls.Add(this.label29);
            this.PgbTypePrediction.Controls.Add(this.comboBoxWeapon);
            this.PgbTypePrediction.Controls.Add(this.numericUpDownLatitude);
            this.PgbTypePrediction.Controls.Add(this.label30);
            this.PgbTypePrediction.Controls.Add(this.numericUpDownLongitude);
            this.PgbTypePrediction.Controls.Add(this.numericUpDownPerpetratorAge);
            this.PgbTypePrediction.Controls.Add(this.comboBoxPerpetratorGender);
            this.PgbTypePrediction.Controls.Add(this.comboBoxVictimGender);
            this.PgbTypePrediction.Controls.Add(this.numericUpDownVictimAge);
            this.PgbTypePrediction.Location = new System.Drawing.Point(143, 6);
            this.PgbTypePrediction.Name = "PgbTypePrediction";
            this.PgbTypePrediction.Size = new System.Drawing.Size(570, 484);
            this.PgbTypePrediction.TabIndex = 25;
            this.PgbTypePrediction.TabStop = false;
            this.PgbTypePrediction.Text = "Тип преступления:";
            // 
            // btnForecast
            // 
            this.btnForecast.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForecast.Location = new System.Drawing.Point(188, 438);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(173, 40);
            this.btnForecast.TabIndex = 34;
            this.btnForecast.Text = "Спрогнозировать";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Активность преступника до:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 18;
            this.label17.Text = "Дата:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(20, 58);
            this.datePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 28);
            this.datePicker.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(292, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Температура воздуха:";
            // 
            // comboBoxPreviousActivity
            // 
            this.comboBoxPreviousActivity.FormattingEnabled = true;
            this.comboBoxPreviousActivity.Items.AddRange(new object[] {
            "None",
            "Burglary",
            "Theft",
            "Vandalism",
            "Forgery",
            "Robbery",
            "Fraud",
            "Embezzlement",
            "Assault",
            "Drug Offense"});
            this.comboBoxPreviousActivity.Location = new System.Drawing.Point(296, 398);
            this.comboBoxPreviousActivity.Name = "comboBoxPreviousActivity";
            this.comboBoxPreviousActivity.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPreviousActivity.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "Время:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(292, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Погода:";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.Location = new System.Drawing.Point(296, 344);
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownTemperature.TabIndex = 14;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(20, 115);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 28);
            this.timePicker.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(291, 205);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 20);
            this.label21.TabIndex = 29;
            this.label21.Text = "Вред здоровью:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "Местоположение:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(292, 150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 20);
            this.label23.TabIndex = 28;
            this.label23.Text = "Оружие:";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Kamakshipalya",
            "Electronic City",
            "Banashankari",
            "Jayanagar",
            "HSR Layout",
            "Marathahalli",
            "JP Nagar",
            "Koramangala",
            "Yelahanka",
            "Whitefield",
            "Indiranagar",
            "Bellandur"});
            this.comboBoxLocation.Location = new System.Drawing.Point(20, 172);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLocation.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(292, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(165, 20);
            this.label24.TabIndex = 27;
            this.label24.Text = "Возраст преступника:";
            // 
            // comboBoxWeather
            // 
            this.comboBoxWeather.FormattingEnabled = true;
            this.comboBoxWeather.Items.AddRange(new object[] {
            "Clear",
            "Overcast",
            "Partly Cloudy",
            "Rain",
            "Snow"});
            this.comboBoxWeather.Location = new System.Drawing.Point(296, 285);
            this.comboBoxWeather.Name = "comboBoxWeather";
            this.comboBoxWeather.Size = new System.Drawing.Size(121, 28);
            this.comboBoxWeather.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(292, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 20);
            this.label26.TabIndex = 26;
            this.label26.Text = "Пол преступника:";
            // 
            // comboBoxInjury
            // 
            this.comboBoxInjury.FormattingEnabled = true;
            this.comboBoxInjury.Items.AddRange(new object[] {
            "None",
            "Minor",
            "Major",
            "Fatal"});
            this.comboBoxInjury.Location = new System.Drawing.Point(296, 228);
            this.comboBoxInjury.Name = "comboBoxInjury";
            this.comboBoxInjury.Size = new System.Drawing.Size(121, 28);
            this.comboBoxInjury.TabIndex = 11;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 376);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 20);
            this.label27.TabIndex = 25;
            this.label27.Text = "Возраст жертвы:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 205);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 20);
            this.label28.TabIndex = 22;
            this.label28.Text = "Широта:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 323);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 20);
            this.label29.TabIndex = 24;
            this.label29.Text = "Пол жертвы:";
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Items.AddRange(new object[] {
            "None",
            "Knife",
            "Gun",
            "Blunt Object"});
            this.comboBoxWeapon.Location = new System.Drawing.Point(295, 172);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(121, 28);
            this.comboBoxWeapon.TabIndex = 10;
            // 
            // numericUpDownLatitude
            // 
            this.numericUpDownLatitude.DecimalPlaces = 4;
            this.numericUpDownLatitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownLatitude.Location = new System.Drawing.Point(20, 228);
            this.numericUpDownLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numericUpDownLatitude.Name = "numericUpDownLatitude";
            this.numericUpDownLatitude.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownLatitude.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 262);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 20);
            this.label30.TabIndex = 23;
            this.label30.Text = "Долгота:";
            // 
            // numericUpDownLongitude
            // 
            this.numericUpDownLongitude.DecimalPlaces = 4;
            this.numericUpDownLongitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownLongitude.Location = new System.Drawing.Point(20, 285);
            this.numericUpDownLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numericUpDownLongitude.Name = "numericUpDownLongitude";
            this.numericUpDownLongitude.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownLongitude.TabIndex = 5;
            // 
            // numericUpDownPerpetratorAge
            // 
            this.numericUpDownPerpetratorAge.Location = new System.Drawing.Point(296, 115);
            this.numericUpDownPerpetratorAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownPerpetratorAge.Name = "numericUpDownPerpetratorAge";
            this.numericUpDownPerpetratorAge.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownPerpetratorAge.TabIndex = 7;
            // 
            // comboBoxPerpetratorGender
            // 
            this.comboBoxPerpetratorGender.FormattingEnabled = true;
            this.comboBoxPerpetratorGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxPerpetratorGender.Location = new System.Drawing.Point(296, 58);
            this.comboBoxPerpetratorGender.Name = "comboBoxPerpetratorGender";
            this.comboBoxPerpetratorGender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPerpetratorGender.TabIndex = 9;
            // 
            // comboBoxVictimGender
            // 
            this.comboBoxVictimGender.FormattingEnabled = true;
            this.comboBoxVictimGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.comboBoxVictimGender.Location = new System.Drawing.Point(20, 344);
            this.comboBoxVictimGender.Name = "comboBoxVictimGender";
            this.comboBoxVictimGender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVictimGender.TabIndex = 8;
            // 
            // numericUpDownVictimAge
            // 
            this.numericUpDownVictimAge.Location = new System.Drawing.Point(20, 399);
            this.numericUpDownVictimAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownVictimAge.Name = "numericUpDownVictimAge";
            this.numericUpDownVictimAge.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownVictimAge.TabIndex = 6;
            // 
            // PgbForecast
            // 
            this.PgbForecast.Controls.Add(this.textBoxPredictionResult);
            this.PgbForecast.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PgbForecast.Location = new System.Drawing.Point(230, 496);
            this.PgbForecast.Name = "PgbForecast";
            this.PgbForecast.Size = new System.Drawing.Size(370, 65);
            this.PgbForecast.TabIndex = 24;
            this.PgbForecast.TabStop = false;
            this.PgbForecast.Text = "Прогноз:";
            // 
            // textBoxPredictionResult
            // 
            this.textBoxPredictionResult.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPredictionResult.Location = new System.Drawing.Point(18, 33);
            this.textBoxPredictionResult.Name = "textBoxPredictionResult";
            this.textBoxPredictionResult.Size = new System.Drawing.Size(329, 28);
            this.textBoxPredictionResult.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(836, 569);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Информация";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label59);
            this.groupBox12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox12.Location = new System.Drawing.Point(19, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(791, 560);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Информация о программе";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label59.Location = new System.Drawing.Point(6, 27);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(724, 528);
            this.label59.TabIndex = 0;
            this.label59.Text = resources.GetString("label59.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 602);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime Prediction Model";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbMethods.ResumeLayout(false);
            this.gbMethods.PerformLayout();
            this.gbFileWithData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.gbTrainModel.ResumeLayout(false);
            this.gbTrainModel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.REgbFileWithData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReTrain)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.PgbTypePrediction.ResumeLayout(false);
            this.PgbTypePrediction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerpetratorAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVictimAge)).EndInit();
            this.PgbForecast.ResumeLayout(false);
            this.PgbForecast.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbMethods;
        private System.Windows.Forms.GroupBox gbFileWithData;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.RadioButton rbFileWithData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listMetrics;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox REgbFileWithData;
        private System.Windows.Forms.DataGridView dgvReTrain;
        private System.Windows.Forms.Button btnDownloadReTrainer;
        private System.Windows.Forms.Button btnReTrainer;
        private System.Windows.Forms.GroupBox PgbForecast;
        private System.Windows.Forms.TextBox textBoxPredictionResult;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox PgbTypePrediction;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxPreviousActivity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBoxWeather;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxInjury;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.NumericUpDown numericUpDownLatitude;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numericUpDownLongitude;
        private System.Windows.Forms.NumericUpDown numericUpDownPerpetratorAge;
        private System.Windows.Forms.ComboBox comboBoxPerpetratorGender;
        private System.Windows.Forms.ComboBox comboBoxVictimGender;
        private System.Windows.Forms.NumericUpDown numericUpDownVictimAge;
        private System.Windows.Forms.GroupBox gbTrainModel;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDownloadModel;
        private System.Windows.Forms.RadioButton rbTrainModel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRePlay;
        private System.Windows.Forms.Button btnOpenTestData;
        private System.Windows.Forms.Button btnSaveTestData;
        private System.Windows.Forms.Button btnClearPrediction;
        private System.Windows.Forms.Button btnClearReTrainer;
    }
}