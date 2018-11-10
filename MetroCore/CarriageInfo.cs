namespace MetroCore
{
    public class CarriageInfo : JsonSupport
    {
        public string CarriageId = "";
        public string Name = "";
        public double MaxSpeed = 0;
        public double Length = 0;
        public int TimeToWaitOnStation = 0;
        public int TimeToTryCloseDoorsAgain = 0;
        public string SubwayLineId = "";
        
        public override string ToJson()
        {
            JsonDocument jsonDocument = new JsonDocument();
            jsonDocument.AddJsonObject("carriageId", CarriageId);
            return jsonDocument.ToJson();
        }

        public sealed override void FromJson(string json)
        {
            throw new System.NotImplementedException();
        }

        public CarriageInfo(string json)
        {
            FromJson(json);
        }
    }
}