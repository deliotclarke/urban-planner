using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to create classes and and use constructors!!!

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Construct(225.25, 335.75, 33);
            FiveOneTwoEigth.Purchase("Ted Cruz");

            FiveOneTwoEigth.DisplayBuildInfo();

        }
    }
}
