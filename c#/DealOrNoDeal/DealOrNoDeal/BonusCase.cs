using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    internal class BonusCase
    {
        Random rnd = new Random();
        int[] rewards = { 500000, 300000, 150000, 80000, 50000, 25000, 10000 };
        public int GiveReward() 
        {
            int chance = rnd.Next(1, 10);
            if(chance > 5 )
            {
                return rewards[rnd.Next(0, rewards.Length)];
            }
            else
            {
                return 0;
            }
        }
}
}
