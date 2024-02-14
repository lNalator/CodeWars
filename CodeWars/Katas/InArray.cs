using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class InArray
    {
        public static string[] Method(string[] array1, string[] array2)
        {
            return array1.Where(word => array2.Any(lword => lword.Contains(word)))
                    .OrderBy(word => word)
                    .Distinct()
                    .ToArray();
        }
    }
}
