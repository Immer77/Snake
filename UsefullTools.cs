using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsMethods
{
    class UsefullTools
    {
        public static void Velkomst()
        {
            Console.WriteLine("Velkommen til Snake");
        }
        public static void Linje()
        {
            Console.WriteLine("--------------------------");
        }
        public static void Bane()
        {
            char[] myChar = { '\u23a1', '\u23a4', '\u23a3', '\u23a6' };
            
            Console.WriteLine($"{myChar[0]}-------------------------{myChar[1]}\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n|                         |\n{myChar[2]}__________________________{myChar[3]}");
            
        }
    }
}
