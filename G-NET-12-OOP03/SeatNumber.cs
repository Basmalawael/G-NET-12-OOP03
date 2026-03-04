using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP03
{
    internal class StandardTicket : Ticket 
    {
        private string _seatnumber; //field 
      public string SeatNumber { get; set;} //prop

        //ctor
        public StandardTicket( string moviename, decimal price , string seatnumber) :base (moviename, price) 
        {
            _seatnumber = seatnumber;
        }
        //method 

        public override string ToString()
        => base.ToString() + $" | Seat: {SeatNumber}";
        
    }
}
