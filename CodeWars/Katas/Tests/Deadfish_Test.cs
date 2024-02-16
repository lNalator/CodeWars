using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;

namespace CodeWars.Katas.Tests
{
    [TestFixture]
    internal class Deadfish_Test
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {"iiisdoso", new int[] {8, 64}},
            new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string data, int[] expected)
        {
            Assert.That(Deadfish.Method(data), Is.EqualTo(expected));
        }

        private static Random rnd = new Random();

        private static int[] solution(string data)
        {
            List<int> output = new List<int>();
            int value = 0;

            foreach (char op in data)
            {
                if (op == 'i') { ++value; }
                else if (op == 'd') { --value; }
                else if (op == 's') { value *= value; }
                else if (op == 'o') { output.Add(value); }
            }

            return output.ToArray();
        }

        private static string getRandomDeadfish()
        {
            string deadfish = "";
            for (int i = 0; i < 7; ++i)
            {
                deadfish += "idso"[rnd.Next(0, 4)];
            }
            return deadfish + 'o';
        }

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                string test = getRandomDeadfish();
                int[] expected = solution(test);
                int[] actual = Deadfish.Method(test);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
