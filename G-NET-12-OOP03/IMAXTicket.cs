using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP03
{
    internal class IMAXTicket : Ticket
    {
        //prop 
        public bool Is3D { get; set; }

        //ctor
        public IMAXTicket(string moviename , decimal price , bool is3D) 
            : base (moviename , price)
        {
            Is3D = is3D;
        }
        public override decimal PriceAfterTax
        {
            get { decimal finalprice=  Is3D ? (Price + 30) : Price;
                return finalprice * 1.14m;
            }
        }

        public override string ToString()
         => base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        


    }
}
