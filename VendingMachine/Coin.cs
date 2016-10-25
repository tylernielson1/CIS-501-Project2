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
        private CoinDispenser coinDispenser;

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

        public int Value
        {
            get
            {
                return value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
        }

        public Coin(int v, int a, CoinDispenser cd)
        {
            value = v;
            amount = a;
            coinDispenser = cd;
        }

        public void InsertCoin()
        {
            totalCoinsInserted += value;
            amount++;
        }
    }
}
