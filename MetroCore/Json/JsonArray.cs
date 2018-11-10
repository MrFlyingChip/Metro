using System;
using System.Collections.Generic;

namespace MetroCore
{
    public class JsonArray
    {
        private readonly List<string> _array = new List<string>();

        public string ToJson()
        {
            var result = "[";
            foreach (var item in _array)
            {
                result = result + item + ",";
            }

            result = result + "]";
            return result;
        }

        public void AddKeyToArray(string jsonObject)
        {
            _array.Add(jsonObject);
        }

        public List<string> GetArray()
        {
            return _array;
        }

        public static JsonArray CreateJsonArray<T>(List<T> array) where T : IFormattable 
        {
            JsonArray jsonArray = new JsonArray();
            foreach (var item in array)
            {
                jsonArray.AddKeyToArray(item.ToString());
            }
            
            return jsonArray;
        }

        public JsonArray(){}
        
        public JsonArray(string value)
        {
            var temp = "";
            var readValue = false;
            foreach (var c in value)
            {
                if (c == ']')
                {
                    readValue = false;
                    AddKeyToArray(temp);
                    temp = "";
                }
                if (c == ',')
                {
                    AddKeyToArray(temp);
                    temp = "";
                }
                
                if (readValue && c != ',')
                {
                    temp += c;
                }
                
                if (c == '[')
                {
                    readValue = true;
                }
            }
        } 
    }
}