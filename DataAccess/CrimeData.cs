using Microsoft.ML.Data;

namespace PredictionOfCrime.DataAccess
{
    public class CrimeData
    {
        [LoadColumn(0)]
        public string Date { get; set; }

        [LoadColumn(1)]
        public string TimeOfDay { get; set; }

        [LoadColumn(2)]
        public string CrimeType { get; set; }

        [LoadColumn(3)]
        public string Location { get; set; }

        [LoadColumn(4)]
        public float Latitude { get; set; }

        [LoadColumn(5)]
        public float Longitude { get; set; }

        [LoadColumn(6)]
        public string VictimGender { get; set; }

        [LoadColumn(7)]
        public float VictimAge { get; set; }

        [LoadColumn(8)]
        public string PerpetratorGender { get; set; }

        [LoadColumn(9)]
        public float PerpetratorAge { get; set; }

        [LoadColumn(10)]
        public string Weapon { get; set; }

        [LoadColumn(11)]
        public string Injury { get; set; }

        [LoadColumn(12)]
        public string Weather { get; set; }

        [LoadColumn(13)]
        public float Temperature { get; set; }

        [LoadColumn(14)]
        public string PreviousActivity { get; set; }
    }
}