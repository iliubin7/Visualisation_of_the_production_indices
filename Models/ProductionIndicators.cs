namespace Visualisation_of_production_indices.Models
{
    public class ProductionIndicators
    {
        public Result result { get; set; }

    }
    public class Result
    {
        public int days_1 { get; set; }
        public int days_2 { get; set; }

        public string created { get; set; }
        public float param1_1 { get; set; }
        public float param1_2 { get; set; }

        public float param2_1 { get; set; }
        public float param2_2 { get; set; }
        public string param3_1 { get; set; }

        public string param3_2 { get; set; }
        public float param3_3 { get; set; }

        public string param4_1 { get; set; }
        public string param4_2 { get; set; }
        public float param4_3 { get; set; }

        public string param5_1 { get; set; }
        public string param5_2 { get; set; }
        public float param5_3 { get; set; }

        public string param6_1 { get; set; }
        public string param6_2 { get; set; }
        public float param6_3 { get; set; }

        public int param7_1 { get; set; }
        public float param7_2 { get; set; }
        public float param7_3 { get; set; }
        public float param7_4 { get; set; }
        public float param7_5 { get; set; }
        public float param8_1 { get; set; }
        public float param8_2 { get; set; }
        public float param8_3 { get; set; }
        public float param8_4 { get; set; }
        public float param8_5 { get; set; }
        public float param11_1 { get; set; }
        public float param11_2 { get; set; }
        public float param11_3 { get; set; }
        public List<User1> users_1 { get; set; }
        public List<User2> users_2 { get; set; }
    }
    public class User1
    {
        public string? name { get; set; }
        public int tabn { get; set; }
        public float time { get; set; }
    }
    public class User2
    {
        public string name { get; set; }
        public int tabn { get; set; }
        public float time { get; set; }
    }

}
