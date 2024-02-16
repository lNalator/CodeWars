using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class ProductFib
    {
        public static ulong[] Method(ulong prod)
        {
            ulong[] resuslt = { 0, 1, 0 };
            ulong a1 = 0;
            ulong a2 = 1;
            ulong a3 = 0;
            ulong result = 0;

            while (a1 * a2 < prod)
            {
                a3 = a2 + a1;
                a1 = a2;
                a2 = a3;
            }

            return new ulong[] { a1, a2, result = (ulong)(a1 * a2 == prod ? 1 : 0) };
        }
    }
}
