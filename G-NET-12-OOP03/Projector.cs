using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP03
{
    internal class Projector
    {
        public string Model { get; set; } = "Laser-4K";

        /// method 
        public  virtual void Start() =>  Console.WriteLine("Projector Started ");
        public virtual void Stop() => Console.WriteLine("Projector Stopped");


    }
    //------------------------------------------------------------
    internal class Cinema
    {
        public string CinemaName { get; set; } 
        public Projector _projector { get; set; }

        private Ticket[] _tickets;

        private int _count = 0;

        //ctor 
        public Cinema(string name )
        {
            CinemaName = name;
            // بنصنع البروجيكتور جوه السينما (Composition)
            _projector = new Projector();

            _tickets = new Ticket[20];
        }

        //(AddTicket)
        public void AddTicket(Ticket t)
        {
            if (_count < 20)
            {
                _tickets[_count] = t;
                _count++;
               
            }
            else
            {
                Console.WriteLine("Sorry, Cinema is full!");

            }
        }
        //-----------------------
        //PrintAllTickets
         public void PrintAllTickets()
        {
            foreach (var ticket in _tickets)
            {

                if (ticket != null) { Console.WriteLine(ticket.ToString()); }

            }
        }
        //----------------------------=====================================

        public void OpenCinema()
        {
            Console.WriteLine("============ Cinema Opened========== ");
            _projector.Start();

        }
        //-------------------------
        public void ClosedCinema()
        {
            Console.WriteLine("============ Cinema Closed========== ");
            _projector.Stop();

        }



    }
}
