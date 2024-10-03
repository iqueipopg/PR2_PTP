namespace Practice1
{
    class PoliceStation : IMessageWritter
    {
        private int stationID;
        private List<PoliceCar> policeVehicleList { get; set; }
        private bool isAlarmActive;
        private City assignedCity;

        public PoliceStation(int stationID, City assignedCity)
        {
            this.stationID = stationID;
            isAlarmActive = false;
            policeVehicleList = new List<PoliceCar>();
            this.assignedCity = assignedCity;
        }

        public void AddNewCar(PoliceCar car)
        {
            policeVehicleList.Add(car);
            car.SetPoliceStation(this);
            Console.WriteLine(car.WriteMessage($"registered in station {GetStationID()}"));
        }

        public void TriggerAlarm()
        {
            isAlarmActive = true;
        }

        public void DispatchAlarm(LicensedVehicle offender, PoliceCar reportingCar)
        {
            Console.WriteLine(WriteMessage($"alarm activated by {reportingCar.ToString()}. Offender details: {offender.ToString()}"));
            foreach (var car in policeVehicleList)
            {
                if (car != reportingCar && car.IsPatrolling())
                {
                    car.StartPersecution(offender.GetLicensePlate());
                }
            }
        }

        public int GetStationID()
        {
            return stationID;
        }

        public List<PoliceCar> GetPoliceVehicles()
        {
            return policeVehicleList;
        }

        public override string ToString()
        {
            return $"Police Station {GetStationID()}";
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
