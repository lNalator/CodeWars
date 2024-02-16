using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas._6_kyu
{
    public class RepeatAdjacent
    {
        public static int Method(string s)
        {
            List<string> groups = new();

            string currentGroup = "";
            foreach (char c in s)
            {
                if (currentGroup == "" || c == currentGroup.Last())
                {
                    currentGroup += c;
                }
                else
                {
                    groups.Add(currentGroup);
                    currentGroup = c.ToString();
                }
            }
            groups.Add(currentGroup);



            int bigGroups = 0;
            bool isInsideAdjacentGroup = false;

            for (int i = 0; i < groups.Count - 1; i++)
            {
                if (groups[i].Length >= 2 && !isInsideAdjacentGroup && groups[i + 1].Length >= 2)
                {
                    bigGroups++;
                    isInsideAdjacentGroup = true;
                }
                else if (groups[i].Length < 2)
                {
                    isInsideAdjacentGroup = false;
                }
            }
            return bigGroups;
        }
    }
}
