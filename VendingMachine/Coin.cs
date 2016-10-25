using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        private int amount;
        private int inserted;
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

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public int Inserted
        {
            get
            {
                return inserted;
            }
            set
            {
                inserted = value;
            }
        }

        public Coin(int a, int i, CoinDispenser cd)
        {
            amount = a;
            inserted = i;
            coinDispenser = cd;
        }

        public void InsertCoin()
        {
            inserted++;
            totalCoinsInserted += amount;
        }
    }
}
