using Microsoft.ML;
using Microsoft.ML.Data;
using PredictionOfCrime.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;

namespace PredictionOfCrime.Service
{
    // Класс для повторного обучения модели прогнозирования преступлений
    public class ModelReTrainer
    {
        private MLContext _mlContext; // Контекст ML.NET
        private ITransformer _trainedModel; // Обученная модель

        // Конструктор класса, принимающий контекст ML.NET и обученную модель
        public ModelReTrainer(MLContext mlContext, ITransformer trainedModel)
        {
            _mlContext = mlContext; // Присваивание контекста ML.NET
            _trainedModel = trainedModel; // Присваивание обученной модели
        }

        // Метод для повторного обучения модели на новых данных из файла
        public void ReTrainModel(string trainDataPath)
        {
            // Загрузка новых данных из файла
            IDataView newDataView = _mlContext.Data.LoadFromTextFile<CrimeData>(trainDataPath, hasHeader: true, separatorChar: ',');

            // Получение конвейера предобработки данных
            var dataProcessPipeline = GetDataProcessPipeline();

            // Создание нового конвейера обучения модели
            var newTrainingPipeline = dataProcessPipeline
                .Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Повторное обучение модели на новых данных
            _trainedModel = newTrainingPipeline.Fit(newDataView);
        }

        // Метод для повторного обучения модели на одной записи данных
        public void ReTrainModel(CrimeData crimeData)
        {
            // Создание IDataView из одной записи данных
            var singleDataView = _mlContext.Data.LoadFromEnumerable(new List<CrimeData> { crimeData });

            // Получение конвейера предобработки данных
            var dataProcessPipeline = GetDataProcessPipeline();

            // Создание нового конвейера обучения модели
            var newTrainingPipeline = dataProcessPipeline
                .Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Повторное обучение модели на одной записи данных
            _trainedModel = newTrainingPipeline.Fit(singleDataView);
        }

        // Метод для создания конвейера предобработки данных
        private EstimatorChain<ColumnConcatenatingTransformer> GetDataProcessPipeline()
        {
            var dataProcessPipeline = _mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: nameof(CrimeData.CrimeType), outputColumnName: "Label")
                // Применение различных преобразований данных
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
                // Конкатенация признаков
                .Append(_mlContext.Transforms.Concatenate("Features", "EncodedDate", "EncodedTimeOfDay", "EncodedLocation", "NormalizedLatitude", "NormalizedLongitude", "EncodedVictimGender", "EncodedPerpetratorGender", "EncodedWeapon", "EncodedInjury", "EncodedWeather", "EncodedPreviousActivity", "NormalizedVictimAge", "NormalizedPerpetratorAge", "NormalizedTemperature"))
                .AppendCacheCheckpoint(_mlContext);

            return dataProcessPipeline;
        }

        // Метод для сохранения модели в файл
        public void SaveModel(string modelPath)
        {
            if (_trainedModel == null)
            {
                throw new InvalidOperationException("Не удается сохранить модель, поскольку она не была обучена.");
            }

            // Проверка существования директории для сохранения модели
            var directory = Path.GetDirectoryName(modelPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Сохранение модели в файл
            using (var fileStream = new FileStream(modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                _mlContext.Model.Save(_trainedModel, null, fileStream);
            }
        }
    }
}