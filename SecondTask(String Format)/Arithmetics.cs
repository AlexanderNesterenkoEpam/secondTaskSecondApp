using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Arithmetics
    {
        public double GetAverage(List<int> intList)
        {
            int sum = 0;
            foreach (var item in intList)
            {
                sum += item;
            }
          double average  = (double) sum / (intList.Count);

           if( average != Double.NaN )
            {
                return average;
            }
           else
            {
                return 0;
            }
            
        }

        public double GetAverage(List<double> doubleList)
        {
            double sum = 0;
            foreach (var item in doubleList)
            {
                sum += item;
            }
            double average = sum / (double) (doubleList.Count);
            if (average != Double.NaN)
            {
                return average;
            }
            else
            {
                return 0;
            }
        }
    }
}
