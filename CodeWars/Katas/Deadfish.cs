using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class Deadfish
    {
        public static int[] Method(string data)
        {
            List<int> result = new();
            int value = 0;
            data.ToCharArray().ToList().ForEach((char x) =>
            {
                switch (x)
                {
                    case 'i':
                        value++;
                        break;
                    case 'd':
                        value--;
                        break;
                    case 's':
                        value = (int)Math.Pow(value, 2);
                        break;
                    case 'o':
                        Console.WriteLine("Case o has been detected, saving result");
                        result.Add(value);
                        break;
                    default:
                        Console.WriteLine("Only possible input are : i, d, s and o");
                        break;
                } 
            });

            return result.ToArray();
        }

        internal static double Parse(string data)
        {
            throw new NotImplementedException();
        }
    }
}
