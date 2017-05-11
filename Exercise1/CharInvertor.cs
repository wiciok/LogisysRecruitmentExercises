using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class CharInvertor
    {
        /**
         * changes given small letter to capital letter
         * returns other chars without modification*/

        private char CapitalizeLetter(char letter)
        {
            if (letter >= 97 && letter <= 122)
                return (char)(letter - 32);
            else
                return letter;
        }

        /**
         * changes given capital letter to small letter
         * returns other chars without modification*/

        private char DecapitalizeLetter(char letter)
        {
            if (letter >= 65 && letter <= 90)
                return (char)(letter + 32);
            else
                return letter;
        }

        /**
         * Takes an argument of string, returns input string in reverse chars order
         * First char (if it's letter) is capitalized, all other are decapitalized
         * */

        public string CharInversion(string sourceString)
        {
            char[] array = new char[sourceString.Length];

            for (int i = 0; i < sourceString.Length; i++)
                array[i] = DecapitalizeLetter(sourceString[sourceString.Length - i -1]);

            array[0] = CapitalizeLetter(array[0]);

            return new string(array);
        }
    }
}
