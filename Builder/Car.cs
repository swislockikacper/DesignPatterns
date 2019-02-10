namespace Builder
{
    public class Car
    {
        public string Gearbox { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string Wheels { get; set; }
        public string Engine { get; set; }
        public short MaxSpeed { get; set; }
        public short ProductionYear { get; set; }

        public string GetInformation()
            => $"{Type} car with {Gearbox} gearbox, {Body} body, {Wheels} wheels, {Engine} engine, made in {ProductionYear}, it can drive {MaxSpeed} km/h. ";
    }
}
