using CodeWars.Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas._5_kyu
{
    public class NodeSize
    {
        public static int Method(LoopDetector.Node startNode)
        {
            LoopDetector.Node tortoise = startNode;
            LoopDetector.Node hare = startNode.Next;

            // Finding a meeting point in the loop
            while (tortoise != hare)
            {
                tortoise = tortoise.Next;
                hare = hare.Next.Next;
            }

            // Finding the size of the loop
            int loopSize = 1;
            hare = hare.Next;
            while (tortoise != hare)
            {
                hare = hare.Next;
                loopSize++;
            }

            return loopSize;
        }
    }
}
