using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;

namespace CodeWars.Katas._6_kyu.Tests
{
    [TestFixture]
    internal class Deadfish_Test
    {
        private static readonly object[] sampleTestCases = new object[]
        {
            new object[] {"iiisdoso", new int[] {8, 64}},
            new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
        };

        [Test, TestCaseSource(nameof(sampleTestCases))]
        public void SampleTest(string data, int[] expected)
        {
            Assert.That(Deadfish.Method(data), Is.EqualTo(expected));
        }

        private static readonly Random rnd = new();

        private static int[] Solution(string data)
        {
            List<int> output = new();
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

        private static string GetRandomDeadfish()
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
                string test = GetRandomDeadfish();
                int[] expected = Solution(test);
                int[] actual = Deadfish.Method(test);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}
