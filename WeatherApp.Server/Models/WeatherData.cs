namespace WeatherApp.Server.Models
{
    public class WeatherData
    {
        public Coords Coord { get; set; }
        //public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        //public Main Main { get; set; }
        public int Visibility { get; set; }
        //public Wind Wind { get; set; }
        //public Rain Rain { get; set; }
        //public Clouds Clouds { get; set; }
        public long Dt { get; set; }
        //public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

        public class Coords
        {
            public double Lon { get; set; }
            public double Lat { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Main
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public int SeaLevel { get; set; }
            public int GrndLevel { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            public int Deg { get; set; }
            public double Gust { get; set; }
        }

        public class Rain
        {
            public double OneHour { get; set; }

            // Use [JsonProperty] for correct mapping if using Newtonsoft.Json
            [System.Text.Json.Serialization.JsonPropertyName("1h")]
            public double _1h { set => OneHour = value; }
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Sys
        {
            public int Type { get; set; }
            public int Id { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }
    }

}
