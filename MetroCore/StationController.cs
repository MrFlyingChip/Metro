using System.Collections.Generic;

namespace MetroCore
{
    public class StationController
    {
        private readonly Dictionary<string, Station> _stations = new Dictionary<string, Station>();
        
        public Station GetStationById(string stationId)
        {
            return _stations.ContainsKey(stationId) ? _stations[stationId] : null;
        }

        public void InitStations()
        {
            
        }
        
        //Singleton
        private static StationController _instance;
        private static readonly object SyncRoot = new object();

        public static StationController Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new StationController();
                }

                return _instance;
            }
        }

        private StationController(){}
    }
}