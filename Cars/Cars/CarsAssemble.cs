using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class CarsAssemble
    {
        private static int Number_In_Hours = 221;

        public double SuccessRate(int speed)
        {
            if(1 <= speed && speed <= 4)
            {
                return 1.0;
            }
            if(5 <= speed && speed <= 8)
            {
                return 0.9;
            }
            if(9 >= speed)
            {
                return 0.8;
            }
            if(10 == speed)
            {
                return 0.77;
            }
            return speed;
        }
        public double productionRatePerHour(int speed)
        {
            return Number_In_Hours * speed * SuccessRate(speed);
        }
        public int workingItemsPerMinute(int speed)
        {
            return (int)productionRatePerHour(speed) / 60;
        }
    }
}
