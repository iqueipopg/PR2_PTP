namespace Practice1
{
    class City : IMessageWritter
    {
        private string cityLabel;
        private List<PoliceStation> stationCollection;
        private List<string> taxiRegistry;

        public City(string cityLabel)
        {
            this.cityLabel = cityLabel;
            this.stationCollection = new List<PoliceStation>();
            this.taxiRegistry = new List<string>();
        }

        public void AddStation(PoliceStation station)
        {
            stationCollection.Add(station);
            Console.WriteLine(WriteMessage($"{station.WriteMessage("registered station.")}"));
        }

        public void RemoveStation(PoliceStation station)
        {
            stationCollection.Remove(station);
            Console.WriteLine(WriteMessage($"{station.WriteMessage("removed station.")}"));
        }

        public void RegisterTaxi(Taxi taxi)
        {
            taxiRegistry.Add(taxi.GetLicensePlate());
            taxi.SetIsLicensed();
            Console.WriteLine(WriteMessage($"{taxi.WriteMessage("registered taxi.")}"));
        }

        public void UnregisterTaxi(Taxi taxi)
        {
            taxiRegistry.Remove(taxi.GetLicensePlate());
            taxi.RemoveLicense();
            Console.WriteLine(WriteMessage($"{taxi.WriteMessage("license removed.")}"));
        }

        public string GetCityLabel()
        {
            return cityLabel;
        }

        public override string ToString()
        {
            return $"City {GetCityLabel()}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}


