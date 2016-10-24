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
        private PurchaseButton pb;
        private Light soldOutLight;
        private Light purchasableLight;
        private CanDispenser canDispense;


        public Can(int p, int s, string t, PurchaseButton pur, Light sol, Light purl, CanDispenser cd)
        {
            price = p;
            stock = s;
            type = t;
            pb = pur;
            soldOutLight = sol;
            purchasableLight = purl;
            canDispense = cd;
        }

        public void Purchase()
        {
            if(purchasableLight.IsOn() && !soldOutLight.IsOn())
            {
                canDispense.Actuate();
                stock--;
                //TODO: add rest of purchase method.
            }
        }


    }
}
