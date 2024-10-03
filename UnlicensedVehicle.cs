namespace Practice1
{
    abstract class UnlicensedVehicle : Vehicle
    {
        public UnlicensedVehicle(string vehicleCategory) : base(vehicleCategory)
        {
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()}";
        }
    }
}
