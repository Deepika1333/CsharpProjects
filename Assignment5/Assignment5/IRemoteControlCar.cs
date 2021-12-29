using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface IRemoteControlCar
    {
        void Drive();
        int DistanceTravelled { get; set; }
    }
    public class ProductionRemoteControlCar : IComparable<ProductionRemoteControlCar>
    {
        public int DistanceTravelled = 10;
        public int NumberOfVictories { get; set; }
        public void Drive()
        {
            Console.WriteLine(DistanceTravelled);
        }
        public static void GetRankedCars()
        {
            var prc1 = new ProductionRemoteControlCar();
            var prc2 = new ProductionRemoteControlCar();
            prc1.NumberOfVictories = 3;
            prc2.NumberOfVictories = 2;
        }

        public int CompareTo(ProductionRemoteControlCar other)
        {
            return NumberOfVictories.CompareTo(other.NumberOfVictories);
        }
    }
    public class ExperimentalRemoteControlCar
    {
        public int DistanceTravelled = 20;
        public void Drive()
        {
            DistanceTravelled = 20;
            Console.WriteLine(DistanceTravelled);
        }

    }
    static class TestTrack
    {
        public static void Race(ProductionRemoteControlCar prod)
        {
            Console.WriteLine(prod.DistanceTravelled);
        }
        public static void Race(ExperimentalRemoteControlCar exp)
        {
            Console.WriteLine(exp.DistanceTravelled);
        }
    }
 
}
