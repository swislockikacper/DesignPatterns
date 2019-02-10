namespace Builder
{
    interface ICarBuilder
    {
        void SetType();
        void InstallBody();
        void InstallWheels();
        void InstallGearbox();
        void InstallEngine();
        void SetRestrictions();
        Car GetCar();
    }
}
