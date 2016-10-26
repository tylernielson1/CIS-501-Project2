//////////////////////////////////////////////////////////////////////
//      Vending Machine (Actuators.cs)                              //
//      Written by Masaaki Mizuno, (c) 2006, 2007, 2008, 2010, 2011 //
//                      for Learning Tree Course 123P, 252J, 230Y   //
//                 also for KSU Course CIS501                       //  
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    // For each class, you can (must) add fields and overriding constructors

    public class CoinInserter
    {
        // add a field to specify an object that CoinInserted() will firstvisit
        private Coin coinInserted;

        // rewrite the following constructor with a constructor that takes an object
        // to be set to the above field
        public CoinInserter(Coin c)
        {
            coinInserted = c;
        }
        public void CoinInserted()
        {
            coinInserted.InsertCoin();
        }

    }

    public class PurchaseButton
    {
        // add a field to specify an object that ButtonPressed() will first visit
        private Can canPurchased;

        public PurchaseButton(Can c)
        {
            canPurchased = c;
        }
        public void ButtonPressed()
        {
            canPurchased.Purchase();
        }
    }

    public class CoinReturnButton
    {
        // add a field to specify an object that Button Pressed will visit
        // replace the following default constructor with a constructor that takes
        // an object to be set to the above field

        private VendingMachine vm;
        public CoinReturnButton(VendingMachine v)
        {
            vm = v;
        }
        public void ButtonPressed()
        {
            vm.GetChange();
        }
    }
}
