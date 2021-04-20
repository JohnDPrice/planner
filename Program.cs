using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 12,
                Width = 145.45,
                Depth = 500.20
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Timothy");

            Console.WriteLine($"\n{FiveOneTwoEigth.GetAddress()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Designed by {FiveOneTwoEigth.GetDesigner()}\nConstructed on {FiveOneTwoEigth.GetTime()}\nOwned by {FiveOneTwoEigth.GetOwner()}\n{Math.Round(FiveOneTwoEigth.Volume)} cubic meters of space\n");

            Building TallBuilding = new Building("732 Washington Drive")
            {
                Stories = 500,
                Width = 180,
                Depth = 200000
            };

            TallBuilding.Construct();
            TallBuilding.Purchase("Gregory");

            Console.WriteLine($"\n{TallBuilding.GetAddress()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Designed by {TallBuilding.GetDesigner()}\nConstructed on {TallBuilding.GetTime()}\nOwned by {TallBuilding.GetOwner()}\n{Math.Round(TallBuilding.Volume)} cubic meters of space\n");

            Building ShortBuilding = new Building("94 Tacoma Rd")
            {
                Stories = 2,
                Width = 100,
                Depth = 20
            };

            ShortBuilding.Construct();
            ShortBuilding.Purchase("Jimmy Diego");

            Console.WriteLine($"\n{ShortBuilding.GetAddress()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Designed by {ShortBuilding.GetDesigner()}\nConstructed on {ShortBuilding.GetTime()}\nOwned by {ShortBuilding.GetOwner()}\n{Math.Round(ShortBuilding.Volume)} cubic meters of space\n");
        }
    }
}
