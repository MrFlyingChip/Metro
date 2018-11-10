namespace MetroCore
{
    public class Carriage : JsonSupport
    {
        private CarriageInfo _carriageInfo = null;
        private double _currentSpeed = 0;
        private bool _isGoing = false;
        private bool _isOpeningDoors = false;
        private Station _currentStation = null;
        private SubwayLine _currentSubwayLine = null;
        
        public override string ToJson()
        {
            throw new System.NotImplementedException();
        }

        public override void FromJson(string json)
        {
            throw new System.NotImplementedException();
        }

        public void InitCarriage(string carriageInfo)
        {
            _carriageInfo = new CarriageInfo(carriageInfo);
            if (_carriageInfo != null)
            {
                   
            }
        }
    }
}