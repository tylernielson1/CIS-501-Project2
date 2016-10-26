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

        public CoinDispenser CoinDispense
        {
            get
            {
                return coinDispenser;
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

        /*public static bool GetChange()
        {
            //TODO: figure this ish out.
            int[] coinsUsed = new int[VendingMachine.coinsInserted.Length];
            int totalCoins = Coin.TotalCoinsInserted;
            for (int i = VendingMachine.coinsInserted.Length - 1; i >= 0; i--)
            {
                coinsUsed[i] = (totalCoins / VendingMachine.coinsInserted[i].Amount);
                if (coinsUsed[i] > VendingMachine.coinsInserted[i].Inserted)
                {
                    coinsUsed[i] = 0;
                    return false;
                }
                else
                {
                    totalCoins -= (coinsUsed[i] * VendingMachine.coinsInserted[i].Amount);
                    VendingMachine.coinsInserted[i].Inserted -= coinsUsed[i];
                }
            }

            Coin.TotalCoinsInserted = totalCoins;
            for (int i = VendingMachine.coinsInserted.Length - 1; i >= 0; i--)
            {
                VendingMachine.coinsInserted[i].CoinDispense.Actuate(coinsUsed[i]);
            }
            return true;
            //Coin.TotalCoinsInserted = 0;

            /*if(totalCoins > 0)
            {
                noChangeLight.TurnOn3Sec();
            }

            //updateDebugDisplays();
        }*/
    }
}
