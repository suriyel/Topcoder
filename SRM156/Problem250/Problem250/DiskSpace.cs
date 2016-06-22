using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem250
{
    public class DiskSpace
    {
        public int minDrives(int[] used, int[] total)
        {
            var totalCost = used.Sum();
            var count = 0;
            var sum = 0;
            foreach (var capacity in total.ToList().OrderByDescending(r => r))
            {
                sum += capacity;
                count++;
                if (sum >= totalCost)
                {
                    break;
                }
            }


            return count;
        }
    }
}
