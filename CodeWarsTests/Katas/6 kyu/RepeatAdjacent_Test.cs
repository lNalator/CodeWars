using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework.Legacy;

namespace CodeWars.Katas._6_kyu.Tests
{
    [TestFixture]
    internal class RepeatAdjacent_Test
    {
        private static int An(string s)
        {
            var r = Regex.Matches(s, "((.)\\2+(?!\\2)){2,}");
            //Console.WriteLine(string.Join("|||",r.OfType<Match>().Select(x=>x.Value)));
            return r.OfType<Match>().Count();
        }

        private string Rndtest()
        {
            var len = Rand(1, 20);
            var r = new List<string>();
            for (var i = 0; i < len; i++) r.Add(Rand(0, 1) > 0 ? "" + Rndcl() : new string(Rndcl(), Rand(2, 7)));
            return string.Join("", r);
        }

        //Tools
        private void Shuff(List<int> r)
        {
            for (int i = 0; i < 50; i++)
            {
                int idx1 = Rand(0, r.Count - 1), idx2 = Rand(0, r.Count - 1);
                (r[idx2], r[idx1]) = (r[idx1], r[idx2]);
            }
        }
        private static string Repeat(string c, int n)
        {
            var s = new string('&', n);
            return Regex.Replace(s, "&", c);
        }

        readonly Random rndnum = new(unchecked((int)DateTime.Now.Ticks));
        private int Rand(int a, int b)
        {
            return a > b ? Rand(b, a) : rndnum.Next(a, b + 1);
        }
        private int[] Rndarr(int minlen, int maxlen, int minv, int maxv)
        {
            var len = Rand(minlen, maxlen);
            var r = new int[len];
            for (var i = 0; i < len; i++) r[i] = Rand(minv, maxv);
            return r;
        }
        private string Rnds(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(Rndcl());
            return string.Join("", rs);
        }
        private string Rndss(int n)
        {
            var len = n;
            var rs = new List<string>();
            for (int i = 0; i < len; i++) rs.Add(Rnds(Rand(3, 7)));
            return string.Join(" ", rs);
        }
        private string Rnds2(int n)
        {
            var len = n;
            var rs = new List<char>();
            for (int i = 0; i < len; i++) rs.Add(Rndch());
            return string.Join("", rs);
        }
        private char Rndcl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyz";
            return allc[Rand(0, allc.Length - 1)];
        }
        private char Rndchl()
        {
            var allc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[Rand(0, allc.Length - 1)];
        }
        private char Rndch()
        {
            var allc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return allc[Rand(0, allc.Length - 1)];
        }
        [Test]
        public void Test1__Basic_Tests()
        {
            var passed = "<font size=2 color='#8FBC8F'>Test Passed!</font>\n";

            Assert.That(RepeatAdjacent.Method("ccccoodeffffiiighhhhhhhhhhttttttts"), Is.EqualTo(3));
            Console.WriteLine(passed);
            Assert.That(RepeatAdjacent.Method("soooooldieeeeeer"), Is.EqualTo(0));
            Console.WriteLine(passed);
            Assert.That(RepeatAdjacent.Method("ccccoooooooooooooooooooooooddee"), Is.EqualTo(1));
            Console.WriteLine(passed);
            Assert.That(RepeatAdjacent.Method("chaaallengee"), Is.EqualTo(1));
            Console.WriteLine(passed);
            Assert.That(RepeatAdjacent.Method("wwwwaaaarrioooorrrrr"), Is.EqualTo(2));
            Console.WriteLine(passed);
            Assert.That(RepeatAdjacent.Method("gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp"), Is.EqualTo(2));
            Console.WriteLine(passed);
            Console.WriteLine(" ");

        }

        [Test]
        public void Test2__100_Random_Tests()
        {
            for (int i = 0; i < 100; i++)
            {
                var ab = Rndtest();
                //var cd=rand(0,3)>0?rand(10000,1048576):rand(1,10000);
                //var cd=rand(0,100000);
                Console.WriteLine("<font size=2 color='#CFB53B'>Testing for: " +
                //"\narr = new int[]{"+string.Join(", ",ab)+"}"
                //+"\nb = new int[]{"+string.Join(", ",ab[1])+"}"
                "\ns = \"" + ab + "\""
                //+"\nn = "+cd
                //+"\nn = "+ab[1]
                //+", numberOfDigits = "+ab[1]
                //+", loved = "+ab[2]
                //+", s = "+ab[3]
                + "</font>");
                var answer = An(ab);
                Assert.That(RepeatAdjacent.Method(ab), Is.EqualTo(answer));
                Console.WriteLine("<font size=2 color='#8FBC8F'>" +
                "Pass Value = " + answer + "</font>\n");
                Console.WriteLine(" ");
            }

            Console.WriteLine("<div style='width:360px;background-color:gray'><br><font size=2 color='#3300dd'><b>Happy Coding ^_^</b></font>");
            Console.WriteLine("<br><font size=2 color='#5500ee'><b>Thanks for solve this kata,\nI'm waiting for your:<font color='993300'>\nfeedback, voting and ranking ;-)</b></font></div>");

        }
    }
}
