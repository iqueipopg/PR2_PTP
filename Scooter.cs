namespace Practice1
{
    class Scooter : UnlicensedVehicle
    {
        private static string typeOfVehicle = "Scooter";
        public Scooter() : base(typeOfVehicle)
        {
            SetSpeed(20.0f);
        }

    }

}
