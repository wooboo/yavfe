namespace vuejscore.Models
{
    public class WeatherForecast
    {
        public string DateFormatted { get; set; }        

        public string Summary { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
    public class Addon
    {

    }
    public class FlowOneBlock
    {
        public Addon Header { get; set; }
        public Addon Footer { get; set; }
        public string Title { get; set; }

        public StepOneBlock StepOne { get; set; }
        public StepTwoBlock StepTwo { get; set; }

    }
    public class StepOneBlock
    {
        public string Name { get; set; }
        public Addon Content { get; set; }
    }
    public class StepTwoBlock
    {
        public string Name { get; set; }
        public Addon Content { get; set; }
    }
}
