using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Linq;

namespace CodeWars.Katas._6_kyu.Tests
{
    public static class Solution
    {
        public static string Likes(string[] names)
        {
            return names.Length switch
            {
                0 => "no one likes this",// :(
                1 => $"{names[0]} likes this",
                2 => $"{names[0]} and {names[1]} like this",
                3 => $"{names[0]}, {names[1]} and {names[2]} like this",
                _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this",
            };
        }
    }
    
    [TestFixture]
    internal class WhoLikes_Test
    {
        [Test, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(WhoLikes.Method(Array.Empty<string>()), Is.EqualTo("no one likes this"));
                Assert.That(WhoLikes.Method(new string[] { "Peter" }), Is.EqualTo("Peter likes this"));
                Assert.That(WhoLikes.Method(new string[] { "Jacob", "Alex" }), Is.EqualTo("Jacob and Alex like this"));
                Assert.That(WhoLikes.Method(new string[] { "Max", "John", "Mark" }), Is.EqualTo("Max, John and Mark like this"));
                Assert.That(WhoLikes.Method(new string[] { "Alex", "Jacob", "Mark", "Max" }), Is.EqualTo("Alex, Jacob and 2 others like this"));
            });
        }

        private static readonly Random rnd = new();
        public static string[] names = new string[100].Select(_ => MakeWord()).ToArray();

        private static string MakeWord() =>
          String.Concat(new char[5].Select(_ => (char)rnd.Next(97, 123)));

        [Test, Description("Should return correct text for 0 names")]
        public void ZeroNameTest()
        {
            Assert.That(WhoLikes.Method(Array.Empty<string>()), Is.EqualTo(Solution.Likes(Array.Empty<string>())));
        }

        [Test, Description("Should return correct text for 1 name")]
        public void OneNameTest()
        {
            Assert.That(WhoLikes.Method(names.Take(1).ToArray()), Is.EqualTo(Solution.Likes(names.Take(1).ToArray())));
        }

        [Test, Description("Should return correct text for 2 names")]
        public void TwoNameTest()
        {
            Assert.That(WhoLikes.Method(names.Take(2).ToArray()), Is.EqualTo(Solution.Likes(names.Take(2).ToArray())));
        }

        [Test, Description("Should return correct text for 3 names")]
        public void ThreeNameTest()
        {
            Assert.That(WhoLikes.Method(names.Take(3).ToArray()), Is.EqualTo(Solution.Likes(names.Take(3).ToArray())));
        }

        [Test, Description("Should return correct text for 4 or more names")]
        public void FourNameTest()
        {
            // 4 names
            Assert.That(WhoLikes.Method(names.Take(4).ToArray()), Is.EqualTo(Solution.Likes(names.Take(4).ToArray())));

            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                names = names.OrderBy(_ => rnd.Next()).ToArray();
                string[] test = names.Take(rnd.Next(0, 101)).ToArray();

                string expected = Solution.Likes(test);
                string actual = WhoLikes.Method(test);

                Assert.That(actual, Is.EqualTo(expected));
            }
        }

    }
}
