namespace Builder
{
    class StandardCarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public Car GetCar() => car;

        public void InstallBody() => car.Body = $"Standard";

        public void InstallEngine() => car.Engine = $"Standard";

        public void InstallGearbox() => car.Gearbox = $"Standard";

        public void InstallWheels() => car.Wheels = $"Standard";

        public void SetRestrictions()
        {
            car.MaxSpeed = 185;
            car.ProductionYear = 2019;
        }

        public void SetType() => car.Type = $"Standard";
    }
}
