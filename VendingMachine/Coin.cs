using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        private int value;
        private int amount;
        private CoinInserter coinInserter;

        private static int totalCoinsInserted;

        public static int TotalCoinsInserted
        {
            get
            {
                return totalCoinsInserted;
            }
            set
            {
                totalCoinsInserted = value;
            }
        }

        public Coin(int v, int a, CoinInserter ci)
        {
            value = v;
            amount = a;
            coinInserter = ci;
        }
    }
}
