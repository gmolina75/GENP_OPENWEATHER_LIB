using System.Collections.Generic;

namespace GENP_OPENWEATHER_LIB
{
    public class OpenWeather
    {
        //public int MyProperty { get; set; }
        public double lat { get; set; }//Geographical coordinates of the location(latitude)
        public double lon { get; set; }//Geographical coordinates of the location(longitude)
        public string timezone { get; set; }//Timezone name for the requested location
        public int timezone_offset { get; set; }//Shift in seconds from UTC
        public weatherdata current { get; set; }// Current weather data API response
        public List<weatherdata> hourly { get; set; }// 
        public List<weatherdata> dayly { get; set; }//
    }
    // Current weather data API response
    public class weatherdata
    {

        public int dt { get; set; }//Current time, Unix, UTC
        public int sunrise { get; set; }//Sunrise time, Unix, UTC
        public int sunset { get; set; }//Sunset time, Unix, UTC
        public double temp { get; set; }//Temperature. Units - default: kelvin, metric: Celsius, imperial: Fahrenheit.How to change units used
        public double feels_like { get; set; }//Temperature. This temperature parameter accounts for the human perception of weather.Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        public double pressure { get; set; }//Atmospheric pressure on the sea level, hPa
        public double humidity { get; set; }//Humidity, %
        public double dew_point { get; set; }//AAtmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form.Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        public double clouds { get; set; }//Cloudiness, %
        public double uvi { get; set; }//UV index
        public double visibility { get; set; }//Average visibility, metres
        public double wind_speed { get; set; }//Wind speed.Wind speed. Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.How to change units used
        public double wind_gust { get; set; }//(where available) Wind gust.Units – default: metre/sec, metric: metre/sec, imperial: miles/hour.How to change units used
        public double wind_deg { get; set; }//Wind direction, degrees (meteorological)
                                            //    public double rain { get; set; }//
                                            //    public double rain.1h (where available) Rain volume for last hour, mm
                                            //    public double snow { get; set; }//
                                            //    public double snow.1h { get; set; }//(where available) Snow volume for last hour, mm
                                            //      public double weather { get; set; }//
                                            //      public double weather.id Weather condition id
                                            //    public double weather.main Group of weather parameters (Rain, Snow, Extreme etc.)
                                            //    public double weather.description Weather condition within the group(full list of weather conditions). Get the output in your language
                                            //    public double weather.icon Weather icon id.How to get icons

    }
}
