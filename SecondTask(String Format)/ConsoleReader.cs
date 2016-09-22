using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask_String_Format_
{
    class ConsoleReader
    {
        private List<string> _userInputList = new List<string>();
        public List<string> ListOfSentences { get { return this._userInputList; } set { } }

        public void ReadConsole()
        {
            string inputString;
            while (true)
            {
                Console.WriteLine("Enter sentence (Empty sentence is for exit): ");
                inputString = Console.ReadLine();
                if (inputString.Equals(""))
                {
                    break;
                }
                else
                {
                    _userInputList.Add(inputString);
                }
            }
        }
    }
}
