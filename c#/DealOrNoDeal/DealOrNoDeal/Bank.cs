using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Bank
    {
        static double[] round_multiplayer = { 1.5, 0.25625, 0.3625, 0.46875, 0.575, 0.68125, 0.68125, 0.89375, 1 };

        public static int MakeOffer(int round, int remaining, int case_count)
        {
            return (int)(remaining / case_count * round_multiplayer[round]);
        }
    }
}
