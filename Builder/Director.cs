namespace Builder
{
    class Director
    {
        public Car CreateCar(ICarBuilder builder)
        {
            builder.SetType();
            builder.InstallBody();
            builder.InstallEngine();
            builder.InstallGearbox();
            builder.InstallWheels();
            builder.SetRestrictions();

            return builder.GetCar();
        }
    }
}
