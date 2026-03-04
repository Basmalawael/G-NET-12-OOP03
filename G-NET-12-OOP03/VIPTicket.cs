using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get;  } = 50;

        //-------------------------------------

        public VIPTicket(string moviename , decimal price , bool loungeaccess) :
            base (moviename ,price)

        {
            LoungeAccess = loungeaccess; 
        }


        public override decimal PriceAfterTax => (Price + ServiceFee) * 1.14m;

        public override string ToString()
        {
            string lounge = LoungeAccess ? "Yes" : "No";
            return base.ToString() + $" | Lounge: {lounge} | Service Fee: {ServiceFee} EGP";
        }



    }

   
}
