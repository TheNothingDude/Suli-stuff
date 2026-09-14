using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    internal class Game
    {
        int round = 0;
        int[] values = { 50000000, 20000000, 15000000, 10000000, 7000000, 5000000, 2500000, 1000000, 800000, 500000, 300000, 150000, 80000, 50000, 25000, 10000, 5000, 1000, 500, 100, 10, 5, 1 };
        int case_count;
        List<Case> cases;
        int[] CasePerRound = { 5, 3, 3, 3, 2, 2, 2, 1, 1 };
        int baseWin;
        int bonusWin;
        int amountWon;
        Random rnd = new Random();
        BonusCase BonusCase;
        bool end;

        public Game(int case_count)
        {
            this.case_count = case_count;
        }
        private void Schuffle()
        {
            Case c;
            for(int i = 0; i < case_count; i++)
            {
                c = new Case(i, values[rnd.Next(0, values.Length)]);         
                cases.Add(c);
            }
        }
    }
}
