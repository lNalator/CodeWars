using CodeWars.Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    internal class NodeSize
    {
        public static int Method(LoopDetector.Node startNode)
        {
            LoopDetector.Node tortoise = startNode;
            LoopDetector.Node hare = startNode.next;

            // Finding a meeting point in the loop
            while (tortoise != hare)
            {
                tortoise = tortoise.next;
                hare = hare.next.next;
            }

            // Finding the size of the loop
            int loopSize = 1;
            hare = hare.next;
            while (tortoise != hare)
            {
                hare = hare.next;
                loopSize++;
            }

            return loopSize;
        }
    }
}
