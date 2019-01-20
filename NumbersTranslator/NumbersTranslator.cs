using System;

namespace NumbersTranslator
{
    public class NumbersTranslator
    {
        

        public string Translate(int number)
        {
            string[] ones = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            string[] teens = { "dziesięć", "jedynaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
            string[] tens = { "", "dziesięć", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
            string[] hundreds = { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };

            int input = number;
            string output = "";


            if (input < 10)
            {
                output = ones[input];
            }
            else if (input < 20)
            {
                output = teens[input - 10];
            }
            else if (input < 100)
            {
                int getOnes = input % 10;
                int getTens = input - getOnes;

                if (getOnes == 0)
                {
                    output = tens[getTens / 10];
                }
                else
                {
                    output = tens[getTens / 10] + " " + ones[getOnes];
                }
            }
            else if (input < 1000)
            {
                int getOnes = input % 10;
                int getTens = input % 100 - getOnes;
                int getHundreds = input - getTens - getOnes;
                if (getTens == 0 && getOnes == 0)
                {
                    output = hundreds[getHundreds / 100];
                }
                else if (getTens == 0 && getOnes != 0)
                {
                    output = hundreds[getHundreds / 100] + " " + ones[getOnes];
                }
                else if (getTens != 0 && getOnes == 0)
                {
                    output = hundreds[getHundreds / 100] + " " + tens[getTens / 10];
                }
                else
                {
                    output = hundreds[getHundreds / 100] + " " + tens[getTens / 10] + " " + ones[getOnes];
                }
            }
            return output;

        }
    }
}
