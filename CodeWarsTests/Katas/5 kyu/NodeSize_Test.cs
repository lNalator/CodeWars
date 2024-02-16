using CodeWars.Ressources;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace CodeWars.Katas._5_kyu.Tests
{
    [TestFixture]
    internal class NodeSize_Test
    {
        readonly Random rnd = new();
        [Test]
        public void FourNodesWithLoopSize3()
        {
            var n1 = new LoopDetector.Node();
            var n2 = new LoopDetector.Node();
            var n3 = new LoopDetector.Node();
            var n4 = new LoopDetector.Node();
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n2;
            Assert.That(NodeSize.Method(n1), Is.EqualTo(3));
        }

        [Test]
        public void RandomChainLoopTest500to1000()
        {
            var tailSize = rnd.Next(500, 1000);
            var loopSize = rnd.Next(500, 1000);
            var n1 = LoopDetector.createChain(tailSize, loopSize);
            Assert.That(NodeSize.Method(n1), Is.EqualTo(loopSize));

        }

        [Test]
        public void RandomChainLoopTest5000to10000()
        {
            var tailSize = rnd.Next(5000, 10000);
            var loopSize = rnd.Next(5000, 10000);
            var n1 = LoopDetector.createChain(tailSize, loopSize);
            Assert.That(NodeSize.Method(n1), Is.EqualTo(loopSize));

        }


        [Test]
        public void RandomChainLoopTest50000to1000000()
        {
            var tailSize = rnd.Next(50000, 1000000);
            var loopSize = rnd.Next(50000, 1000000);
            var n1 = LoopDetector.createChain(tailSize, loopSize);
            Assert.That(NodeSize.Method(n1), Is.EqualTo(loopSize));

        }

    }
}
