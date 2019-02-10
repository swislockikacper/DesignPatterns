using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var sportCarBuilder = new SportCarBuilder();
            var standardCarBuilder = new StandardCarBuilder();

            var sportCar = director.CreateCar(sportCarBuilder);
            var standardCar = director.CreateCar(standardCarBuilder);

            Console.WriteLine(sportCar.GetInformation());
            Console.WriteLine(standardCar.GetInformation());
            Console.ReadKey();
        }
    }
}
