using System.Globalization;

namespace MetroCore
{
    public class JsonObject
    {
        public readonly string key;
        public readonly string value;
        
        
        public string ToJson()
        {
            var result = $"{key}: {value}";
            return result;
        }

        public JsonObject(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
        
        public static string ConvertBoolToJson(bool value)
        {
            return (value) ? "1" : "0";
        }
        
        public static string ConvertIntToJson(int value)
        {
            return value.ToString();
        }
        
        public static string ConvertDoubleToJson(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
        
        public static string ConvertStringToJson(string value)
        {
            return value;
        }
    }
}