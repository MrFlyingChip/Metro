using System.Collections.Generic;

namespace MetroCore
{
    public class JsonDocument
    {
        private readonly List<JsonObject> _array = new List<JsonObject>();

        public void AddJsonObject(string key, string value)
        {
            _array.Add(new JsonObject(key, value));
        }
        
        public void AddJsonObject(string key, int value)
        {
            var num = JsonObject.ConvertIntToJson(value);
            _array.Add(new JsonObject(key, num));
        }
        
        public void AddJsonObject(string key, bool value)
        {
            var num = JsonObject.ConvertBoolToJson(value);
            _array.Add(new JsonObject(key, num));
        }
        
        public void AddJsonObject(string key, double value)
        {
            var num = JsonObject.ConvertDoubleToJson(value);
            _array.Add(new JsonObject(key, num));
        }

        public void AddJsonArray<T>(string key, List<T> value)
        {
            var list = JsonArray.CreateJsonArray(value);
            _array.Add(new JsonObject(key, list.ToJson()));
        }

        public string ToJson()
        {
            var result = "{";
            foreach (var item in _array)
            {
                result = result + item.ToJson() + ",";
            }
            
            result = result + "}";
            return result;
        }
    }
}