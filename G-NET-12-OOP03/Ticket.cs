using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP03
{
    internal class Ticket
    {
        private decimal _price;
        private string _moviename;
        private  static int _count = 0;

      //------------------------------------

        public string MovieName { get; set; }
        public decimal Price {
            get => _price;

            set { if (value > 0) _price = value; }  }

        public int TicketId { get;} //Read Only 
        //----------------------------------------------
        // Ctor 
        public Ticket()
        {
            TicketId = ++_count; 
        }

        public Ticket(string moviename, decimal price) : this()
        {
            MovieName = moviename;
            Price = price;
         
        }
        //------------------------------
        public virtual decimal PriceAfterTax
        {
            get { return Price * 1.14m; }

        }
        //------------------------------
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
        public static int GetTotalTickets ()
        {
            return _count;
        }


    }
}
