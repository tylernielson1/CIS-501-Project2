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
        public Light soldOutLight;
        public Light purchasableLight;
        public CanDispenser canDispense;

        public static CoinReturnButton cr;

        public CoinReturnButton coinReturn
        {
            get
            {
                return cr;
            }
        }

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

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        public Can(int p, int s, string t, Light sol, Light purl, CanDispenser cd, CoinReturnButton c)
        {
            price = p;
            stock = s;
            type = t;
            soldOutLight = sol;
            purchasableLight = purl;
            canDispense = cd;
            cr = c;
        }

        /*public void Purchase()
        {
            if(purchasableLight.IsOn() && !soldOutLight.IsOn())
            {
                if(Coin.GetChange())
                {
                    canDispense.Actuate();
                    this.Stock = this.stock - 1;
                    Coin.TotalCoinsInserted -= this.price;
                    cr.ButtonPressed();
                }
                else
                {
                    vm.no
                }
            }
        }*/

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
            else
            {
                soldOutLight.TurnOff();
            }
        }


    }
}
