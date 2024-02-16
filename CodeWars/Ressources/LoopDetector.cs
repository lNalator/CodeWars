using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Ressources
{
    public class LoopDetector
    {
        public class Node
        {
            public Node next { get; set; }
        }

        public static Node createChain(int tailSize, int loopSize)
        {
            var startNode = new Node();
            var currNode = startNode;
            for (var i = 0; i < tailSize; i++)
            {
                currNode.next = new Node();
                currNode = currNode.next;
            }
            var loopStartNode = currNode;
            for (var i = 0; i < loopSize - 1; i++)
            {
                currNode.next = new Node();
                currNode = currNode.next;
            }
            currNode.next = loopStartNode;
            return startNode;
        }
    }
}
