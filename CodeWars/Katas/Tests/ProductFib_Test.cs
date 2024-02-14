using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas.Tests
{
    internal class ProductFib_Test
    {
        public static void Tests(ulong prod)
        {
            foreach (ulong result in ProductFib.Method(prod))
            {
                Console.WriteLine("result : " + result);
            }
        }
    }
}
