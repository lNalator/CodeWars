using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas.Tests
{
    internal class InArray_Test
    {
        public static void Tests()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

            foreach (string words in InArray.Method(a1, a2))
            {
                Console.WriteLine("result : " + words);
            }
        }
        
}
}
