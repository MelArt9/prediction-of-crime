using Microsoft.ML.Data;

namespace PredictionOfCrime.DataAccess
{
    public class PredictionCrime
    {
        [ColumnName("PredictedLabel")]
        public string PredictedCrimeType { get; set; }
    }
}