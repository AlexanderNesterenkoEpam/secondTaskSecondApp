using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class Action
    {
       public void DoActions()
        {
            ConsoleReader cr = new ConsoleReader();         
            cr.ReadConsole();  //read sentenses from console

            Parser p = new Parser();

            foreach (var item in cr.ListOfSentences)
            {
               string[] splittedString = p.Split(item);
                p.FindInts(splittedString);
                p.FindReals(splittedString);
                p.FindNaN(splittedString);
            }

            Printer printer = new Printer();
            printer.PrintInt(p.IntCount); // show all integers
            printer.PrintReal(p.RealCount);// show all real counts
            printer.Print(p.IntFound);
            Arithmetics ar = new Arithmetics();
            printer.Print(ar.GetAverage(p.IntFound));// get average int

            printer.Print(p.RealFound);
            printer.Print(ar.GetAverage(p.RealFound));// get avarage double
            Console.ReadLine();
        }


    }
}
