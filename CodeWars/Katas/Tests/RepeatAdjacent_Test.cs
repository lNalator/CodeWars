using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas.Tests
{
    internal class RepeatAdjacent_Test
    {
        public static void Tests()
        {
            Console.WriteLine("result 1 : " + RepeatAdjacent.Method("ccccoodeffffiiighhhhhhhhhhttttttts"));
            Console.WriteLine("result 2 : " + RepeatAdjacent.Method("ccccoooooooooooooooooooooooddee"));
            Console.WriteLine("result 3 : " + RepeatAdjacent.Method("soooooldieeeeeer"));
            Console.WriteLine("result 4 : " + RepeatAdjacent.Method("wwwwaaaarrioooorrrrr"));
            Console.WriteLine("result 5 : " + RepeatAdjacent.Method("gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp"));
        }
    }
}
