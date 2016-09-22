using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Printer
    {
        public void Print(List<int> listInt)
        {
            string intValues = "integer values";
            Console.WriteLine(intValues.PadLeft(50));
            foreach (var item in listInt)
            {
                string str = item.ToString();
                Console.WriteLine(str.PadLeft(50));
            }
        }

        public void Print(List<double> listDouble)
        {
            string doubleValues = "double values";
            Console.WriteLine(doubleValues.PadLeft(50));
            foreach (var item in listDouble)
            {
                double rounded = Math.Round(item, 2);
                string str = rounded.ToString();
                Console.WriteLine(str.PadLeft(50));
            }
        }

        public void PrintInt(int num)
        {
            Console.WriteLine(num + " integers in the sentences.");
        }

        public void PrintReal(double num)
        {
            Console.WriteLine(num + " doubles in the sentences.");
        }

        public void Print(double num)
        {
            string str;
            if (num == double.NaN)
            {
                num = 0;
            }
            str = num.ToString();
            
            String average = "average is ";
            Console.WriteLine(average.PadLeft(48) + str.PadLeft(1));
            Console.WriteLine();
        }
    }
}
