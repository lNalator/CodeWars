using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas.Tests
{
    internal class Deadfish_Test
    {
        public static void Tests(string inputs)
        {
            foreach(int x in Deadfish.Method(inputs))
            {
                Console.WriteLine("result : " + x);
            }
            
        }
    }
}
