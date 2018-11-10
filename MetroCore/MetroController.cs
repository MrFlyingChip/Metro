using System;

namespace MetroCore
{
    public class MetroController
    {
        public void Start()
        {
            
        }

        public void ChangeSubwayLineInformation(string information, string subwayLineId)
        {
            //TODO change information about subway line
            RebootSubwayLine(subwayLineId);
        }

        void RebootSubwayLine(string subwayLineId)
        {
            //TODO reboot whole subway line
        }
        
        //Singleton
        private static MetroController _instance;
        private static readonly object SyncRoot = new object();

        public static MetroController Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new MetroController();
                }

                return _instance;
            }
        }

        private MetroController(){}
    }
}