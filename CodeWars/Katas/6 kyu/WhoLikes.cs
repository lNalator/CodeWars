using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas._6_kyu
{
    public class WhoLikes
    {
        public static string Method(string[] name)
        {
            return name.Length switch
            {
                0 => "no one likes this",
                1 => $"{name[0]} likes this",
                2 => $"{name[0]} and {name[1]} like this",
                3 => $"{name[0]}, {name[1]} and {name[2]} like this",
                _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
            };
        }
    }
}
