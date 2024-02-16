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
            public Node Next { get; set; }
        }

        public static Node CreateChain(int tailSize, int loopSize)
        {
            var startNode = new Node();
            var currNode = startNode;
            for (var i = 0; i < tailSize; i++)
            {
                currNode.Next = new Node();
                currNode = currNode.Next;
            }
            var loopStartNode = currNode;
            for (var i = 0; i < loopSize - 1; i++)
            {
                currNode.Next = new Node();
                currNode = currNode.Next;
            }
            currNode.Next = loopStartNode;
            return startNode;
        }
    }
}
