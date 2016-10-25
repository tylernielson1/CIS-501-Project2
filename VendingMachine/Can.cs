using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Can
    {
        private int price;
        private int stock;
        private string type;
        private Light soldOutLight;
        private Light purchasableLight;
        private CanDispenser canDispense;

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }


        public Can(int p, int s, string t, Light sol, Light purl, CanDispenser cd)
        {
            price = p;
            stock = s;
            type = t;
            soldOutLight = sol;
            purchasableLight = purl;
            canDispense = cd;
        }

        public void Purchase()
        {
            if(purchasableLight.IsOn() && !soldOutLight.IsOn())
            {
                canDispense.Actuate();
                this.Stock = this.stock - 1;
                Coin.TotalCoinsInserted -= this.price;
                //TODO: add rest of purchase method.
            }
        }

        public void UpdateLights()
        {
            if (Coin.TotalCoinsInserted >= this.price)
            {
                purchasableLight.TurnOn();
            }
            else
            {
                purchasableLight.TurnOff();
            }
            if(this.stock <= 0)
            {
                soldOutLight.TurnOn();
                purchasableLight.TurnOff();
            }
        }


    }
}
