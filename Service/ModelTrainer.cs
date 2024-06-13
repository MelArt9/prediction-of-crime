using Microsoft.ML; // Импорт пространства имен Microsoft.ML для работы с ML.NET
using PredictionOfCrime.DataAccess; 
using System.IO; 
using Microsoft.ML.Data; 
using System;

namespace PredictionOfCrime.Service
{
    public class ModelTrainer
    {
        private MLContext _mlContext;         // Контекст ML.NET для выполнения операций обучения и предсказания
        private ITransformer _trainedModel;   // Обученная модель ML.NET

        // Конструктор класса, принимающий контекст ML.NET в качестве параметра
        public ModelTrainer(MLContext mlContext)
        {
            _mlContext = mlContext;
        }

        // Метод для обучения модели
        public ITransformer TrainModel(string trainDataPath, string modelPath)
        {
            // Загрузка данных для обучения из CSV-файла
            var trainDataView = _mlContext.Data.LoadFromTextFile<CrimeData>(trainDataPath, hasHeader: true, separatorChar: ',');

            // Создание и настройка конвейера обработки данных
            var dataProcessPipeline = GetDataProcessPipeline();

            // Создание и настройка конвейера обучения модели
            // SdcaMaximumEntropy - это алгоритм машинного обучения, который используется для мультиклассовой классификации
            // в рамках библиотеки ML.NET от Microsoft. Этот алгоритм основан на стохастическом методе оптимизации
            // стохастического градиентного спуска (Stochastic Dual Coordinate Ascent, SDCA) и минимизирует функцию потерь
            // с использованием максимальной энтропии.
            var trainingPipeline = dataProcessPipeline
                .Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(labelColumnName: "Label", featureColumnName: "Features"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Обучение модели на данных
            _trainedModel = trainingPipeline.Fit(trainDataView);

            // Возвращение обученной модели
            return _trainedModel;
        }

        // Метод для создания конвейера обработки данных
        private EstimatorChain<ColumnConcatenatingTransformer> GetDataProcessPipeline()
        {
            // Создание конвейера обработки данных
            var dataProcessPipeline = _mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: nameof(CrimeData.CrimeType), outputColumnName: "Label")
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedDate", inputColumnName: nameof(CrimeData.Date)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedTimeOfDay", inputColumnName: nameof(CrimeData.TimeOfDay)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedLocation", inputColumnName: nameof(CrimeData.Location)))
                .Append(_mlContext.Transforms.NormalizeMinMax(outputColumnName: "NormalizedLatitude", inputColumnName: nameof(CrimeData.Latitude)))
                .Append(_mlContext.Transforms.NormalizeMinMax(outputColumnName: "NormalizedLongitude", inputColumnName: nameof(CrimeData.Longitude)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedVictimGender", inputColumnName: nameof(CrimeData.VictimGender)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedPerpetratorGender", inputColumnName: nameof(CrimeData.PerpetratorGender)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedWeapon", inputColumnName: nameof(CrimeData.Weapon)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedInjury", inputColumnName: nameof(CrimeData.Injury)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedWeather", inputColumnName: nameof(CrimeData.Weather)))
                .Append(_mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "EncodedPreviousActivity", inputColumnName: nameof(CrimeData.PreviousActivity)))
                .Append(_mlContext.Transforms.NormalizeMinMax(outputColumnName: "NormalizedVictimAge", inputColumnName: nameof(CrimeData.VictimAge)))
                .Append(_mlContext.Transforms.NormalizeMinMax(outputColumnName: "NormalizedPerpetratorAge", inputColumnName: nameof(CrimeData.PerpetratorAge)))
                .Append(_mlContext.Transforms.NormalizeMinMax(outputColumnName: "NormalizedTemperature", inputColumnName: nameof(CrimeData.Temperature)))
                .Append(_mlContext.Transforms.Concatenate("Features", "EncodedDate", "EncodedTimeOfDay", "EncodedLocation", "NormalizedLatitude", "NormalizedLongitude", "EncodedVictimGender", "EncodedPerpetratorGender", "EncodedWeapon", "EncodedInjury", "EncodedWeather", "EncodedPreviousActivity", "NormalizedVictimAge", "NormalizedPerpetratorAge", "NormalizedTemperature"))
                .AppendCacheCheckpoint(_mlContext);

            // Возврат конвейера обработки данных
            return dataProcessPipeline;
        }

        // Метод для сохранения обученной модели в файл
        public void SaveModel(string modelPath)
        {
            // Проверка наличия обученной модели
            if (_trainedModel == null)
            {
                throw new InvalidOperationException("Модель не была обучена и не может быть сохранена.");
            }

            // Сохранение модели в указанный файл
            using (var fileStream = new FileStream(modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                _mlContext.Model.Save(_trainedModel, null, fileStream);
            }
        }

    }
}




/* В контексте данного кода, использование алгоритма SDCA Maximum Entropy для обучения модели прогнозирования преступлений 
 * имеет несколько преимуществ:
 * 
 * 1. Высокая точность классификации: Алгоритм SDCA Maximum Entropy известен своей способностью обрабатывать данные 
 *    с высокой размерностью (множество признаков) и предсказывать множество классов с высокой точностью. 
 *    Это особенно важно в задачах, связанных с преступностью, где много факторов может влиять на тип преступления.
 *    
 * 2. Поддержка мультиклассовой классификации: Этот алгоритм хорошо подходит для задач, где необходимо предсказывать один 
 *    из нескольких возможных классов (типов преступлений в данном случае).
 * 
 * 3. Устойчивость к большому объему данных: SDCA позволяет обрабатывать большие объемы данных, что может быть важно для 
 *    обучения модели на больших наборах данных о преступлениях.
 *    
 * 4. Высокая скорость обучения: SDCA имеет высокую скорость сходимости, что может быть полезно при обучении модели на 
 *    больших данных, так как позволяет быстрее достигать приемлемого уровня точности.
 * 
 * 5. Масштабируемость: Алгоритм хорошо масштабируется на множество признаков и объектов, что позволяет обрабатывать данные 
 *    различной природы и объема. */