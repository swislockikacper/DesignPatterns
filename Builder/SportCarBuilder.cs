namespace Builder
{
    class SportCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public Car GetCar() => car;

        public void InstallBody() => car.Body = $"Sport";

        public void InstallEngine() => car.Engine = $"Sport";

        public void InstallGearbox() => car.Gearbox = $"Sport";

        public void InstallWheels() => car.Wheels = $"Sport";

        public void SetRestrictions()
        {
            car.MaxSpeed = 320;
            car.ProductionYear = 2019;
        }

        public void SetType() => car.Type = $"Sport";
    }
}
