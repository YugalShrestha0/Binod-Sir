using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUICalcu
{
    class Arthemetic
    {
        public double calculator(double first, double second, int mode)
        {
            double result = 0;
            switch(mode)
            {
                case 1:
                    result = first + second;
                    break;
                case 2:
                    result = first - second;
                    break;
                case 3:
                    result = first * second;
                    break;
                case 4:
                    result = first / second;
                    break;
            }
            return result;
        }
    }
}
