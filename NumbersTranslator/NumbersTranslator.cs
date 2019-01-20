using System;

namespace NumbersTranslator
{
    public class NumbersTranslator
    {
        int silnikSetek(int amount)
        {

            int input = amount;
            while (input >= 1000000000 && input <= 999999999999)
            { // od miliarda - wyodrębniamy miliony z miliardów
                input -= 1000000000;
            }
            while (input >= 1000000 && input <= 999999999)
            { // od miliona do prawie miliarda - wyodrębniamy tysiące z milionów
                input -= 1000000;
            }
            while (input >= 1000 && input <= 999999)
            { // od tysiąca do prawie miliona - wyodrębniamy setki z tysięcy
                input -= 1000;
            }
            return input;
        }
        int silnikTysiecy(int amount)
        {

            int input = amount;
            while (input >= 1000000000 && input <= 999999999999)
            { // od miliarda - wyodrębniamy miliony z miliardów
                input -= 1000000000;
            }
            while (input >= 1000000 && input <= 999999999)
            { // od miliona do prawie miliarda - wyodrębniamy tysiące z milionów
                input -= 1000000;
            }
            return input;
        }
        int silnikMilionow(int amount)
        {

            int input = amount;
            while (input >= 1000000000 && input <= 999999999999)
            { // od miliarda - wyodrębniamy miliony z miliardów
                input -= 1000000000;
            }
            return input;
        }
        string ONES(int input)
        {
            string output = "";
            switch (input)
            {
                case 1:
                    output = "one";
                    break;
                case 2:
                    output = "two";
                    break;
                case 3:
                    output = "three";
                    break;
                case 4:
                    output = "four";
                    break;
                case 5:
                    output = "five";
                    break;
                case 6:
                    output = "six";
                    break;
                case 7:
                    output = "seven";
                    break;
                case 8:
                    output = "eight";
                    break;
                case 9:
                    output = "nine";
                    break;
                case 10:
                    output = "ten";
                    break;
                case 12:
                    output = "twelve";
                    break;
                case 13:
                    output = "thirteen";
                    break;
                case 14:
                    output = "fourteen";
                    break;
                case 15:
                    output = "fifteen";
                    break;
                case 16:
                    output = "sixteen";
                    break;
                case 17:
                    output = "seventeen";
                    break;
                case 18:
                    output = "eighteen";
                    break;
                case 19:
                    output = "nineteen";
                    break;
                default:
                    break;
            }
            return output;
        }
        string TENS(int input)
        {
            string output = "";
            switch (input)
            {
                case 1:
                    output = "ten";
                    break;
                case 2:
                    output = "twenty";
                    break;
                case 3:
                    output = "thirty";
                    break;
                case 4:
                    output = "fourty";
                    break;
                case 5:
                    output = "fifty";
                    break;
                case 6:
                    output = "sixty";
                    break;
                case 7:
                    output = "seventy";
                    break;
                case 8:
                    output = "eighty";
                    break;
                case 9:
                    output = "ninety";
                    break;
                default:
                    break;
            }
            return output;
        }

        string compute(int input)
        {
            int thousands = input / 1000;
            int hundreds = (input / 100) - thousands * 10;
            int tens = (input / 10) - thousands * 100 - hundreds * 10;
            int ones = input / 1 - thousands * 1000 - hundreds * 100 - tens * 10;

            string output;

            if (input >= 0 && input <= 19)
            {
                tens = 0;
                ones = input - hundreds * 100;
                output = ONES(ones);
            }
            else if (input >= 20 && input <= 99)
            {
                output = TENS(tens) + " " + ONES(ones);
            }
            else
            {
                if (input - hundreds * 100 >= 0 && input - hundreds * 100 <= 19)
                {
                    tens = 0;
                    ones = input - hundreds * 100;
                }
                output = ONES(hundreds) + " hundred " + TENS(tens) + " " + ONES(ones);
            }



            return output;
        }
        public string Translate(int number)
        {
            // --------------- DATA ----------------------------
            int input = number;
            string output = "";
            int setki, tysiace, miliony;

            // ----------- "ENGINE" --------------------------
            setki = silnikSetek(input);
            tysiace = silnikTysiecy(input);
            miliony = silnikMilionow(input);

            tysiace /= 1000;
            miliony /= 1000000;

            if (input <= 999)
            {
                output = compute(setki);
            }
            else if (input >= 999 && input <= 999999)
            {
                output = compute(tysiace) + " thousand " + compute(setki);
            }
            else if (input >= 999999 && input <= 999999999)
            {
                output = compute(miliony) + " milion " + compute(tysiace) + " thousand " + compute(setki);
            }

            return output;

        }
    }
}
