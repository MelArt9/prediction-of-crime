using Microsoft.ML;
using Microsoft.ML.Data;
using System;

namespace PredictionOfCrime.Service
{
    // Класс для тестирования модели прогнозирования преступлений
    public class ModelTester
    {
        private MLContext _mlContext; // Контекст ML.NET
        private ITransformer _trainedModel; // Обученная модель

        // Конструктор класса, принимающий контекст ML.NET и обученную модель
        public ModelTester(MLContext mlContext, ITransformer trainedModel)
        {
            _mlContext = mlContext ?? throw new ArgumentNullException(nameof(mlContext)); // Проверка на null контекста
            _trainedModel = trainedModel ?? throw new ArgumentNullException(nameof(trainedModel)); // Проверка на null модели
        }

        // Метод для тестирования модели на тестовых данных
        public MulticlassClassificationMetrics TestModel(IDataView testData)
        {
            // Получение прогнозов модели на тестовых данных
            var predictions = _trainedModel.Transform(testData);

            // Оценка метрик мультиклассовой классификации на основе прогнозов и фактических меток
            return _mlContext.MulticlassClassification.Evaluate(predictions, "Label", "Score");
        }
    }
}