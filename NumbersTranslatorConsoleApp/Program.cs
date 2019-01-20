using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTranslatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numTranslator = new NumbersTranslator();
            string translatedNumber = numTranslator.Translate(457); // param wejsciowe metody
        }
    }
}
