namespace Practice1
{
    abstract class LicensedVehicle : Vehicle
    {
        private string licensePlate;

        public LicensedVehicle(string typeOfVehicle, string licensePlate) : base(typeOfVehicle)
        {
            this.licensePlate = licensePlate;
        }

        public string GetLicensePlate()
        {
            return this.licensePlate;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetLicensePlate()}";
        }
    }
}
