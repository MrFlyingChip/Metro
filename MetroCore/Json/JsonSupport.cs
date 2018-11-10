namespace MetroCore
{
    public abstract class JsonSupport
    {
        public abstract string ToJson();
        public abstract void FromJson(string json);
    }
}