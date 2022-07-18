using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LesRegex.Classes
{
    internal class Tools
    {
        /*
         * Pattern Regex
         *  ^ = commence
         *  $ = fin
         *  \d = nombre
         *  \w = Letter, Digit, Underscrore
         *  \s = White-Space(tabs, spaces)
         *  \D = Tout sauf les \d
         *  \W = Tout sauf des \w
         *  \S = Tout sauf les \s
         *  | = OU
         *  * = 0 ou plus
         *  + = au moins une fois
         *  ? = 0 ou 1 fois
         *  {1} = nb répétition
         *  {2,4}= 2 à 4 fois
         *  . = tout sauf Return
         */

        public static bool IsName(string name)
        {
            //string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-]*$";
            string pattern = @"^([A-Z]{1})([a-zA-Z\séèë\-]*)$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
