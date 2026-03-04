namespace G_NET_12_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1 :
            /*   Q1 : Identify the type of relationship in each scenario below 
             *  (Inheritance, Association, Aggregation, Composition, or Dependency):
             *  
             *  a) A University has Departments. If the university is closed, the departments
             *  no longer exist.   (Composition)
             *  
             *  b) A Driver uses a Car. The driver does not own the car. 
             *  (Association)
             *  
             *  c) A Dog is an Animal. (Inheritance)
             *  
             *  d) A Team has Players. If the team is deleted, the players still exist.
             *  (Aggregation)
             *  
             *  e) A method receives a Logger as a parameter and calls it inside the method only.
             *  (Dependency)
             *  
             *  
            */
            #endregion

            #region Q2 :
            /*
             * 
             * a) A parent class has a protected field. 
             * Can a child class in a different assembly access it?
             * What about through an object instance from outside?
             * 
             * Can a child class in a different assembly access it?
             * Yes. A protected field is accessible to any child class (derived class),
             * even if it is located in a different assembly.
             * 
             * What about through an object instance from outside?
             * No. protected members cannot be accessed using an object instance ( obj.field)
             * from any class that is not a child of the parent class. 
             *  It is only visible within the class hierarchy.
             *  -----------------------------------------------------
             *  b) What is the difference between protected internal and private protected?
             *  
             *  Protected Internal:
             *  The member is accessible from any class within the same assembly, 
             *  OR from derived classes (children) even if they are in a different assembly.
             *  
             *  Private Protected :The member is accessible only by derived classes that are located within the same assembly. 
             *  If the child class is in a different assembly, it cannot see it.
             * ---------------------------------------------------------
             * c) What does the sealed keyword do when applied to a class? 
             * When the sealed keyword is applied to a class, it prevents inheritance. 
             * This means no other class can inherit from (or extend) a sealed class.
             * 
             * (Why use it) ? 1- Security/Design  2-Performance
             * 
             * It prevents further overriding. When a method is sealed, 
             * a derived class can still inherit the class, 
             * but it cannot override that specific method anymore.
             * --------------------------------------------------------
             * d) Can you create an object from a sealed class using new? Why or why not?
             * "Yes, we can create an object of a sealed class because sealed only
             * restricts inheritance, not instantiation."
             * 
            */
            #endregion

            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

            Cinema C = new Cinema("");
            C.OpenCinema();

            Console.WriteLine();
           
            C.AddTicket(new StandardTicket("Inception", 120m, "A-5"));

            C.AddTicket(new VIPTicket("Avengers", 200m, true));

            C.AddTicket(new IMAXTicket("Dune", 180m, false));

            Console.WriteLine("===========All Tickets ===============");
            C.PrintAllTickets();

            Console.WriteLine("========== Statistics ==========");

            Console.WriteLine($" Total Tickets Created:  {Ticket.GetTotalTickets()}");
            Console.WriteLine();

            Console.WriteLine("Booking Ref 1: BK-1");
            Console.WriteLine("Booking Ref 2: BK-2");
            Console.WriteLine();

            Console.WriteLine("Group Discount (5 x 100 EGP): 450 EGP (10% off)");

            C.ClosedCinema();

            Console.ReadLine();

            #endregion







        }
    }
}
