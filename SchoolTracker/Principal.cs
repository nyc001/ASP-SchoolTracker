using System;
namespace SchoolTracker
{
    class Principal:Member, IPayee
    {
       

        public Principal()
        {

        }

        public void Pay()
        {
            Console.WriteLine("Pay principal");
        }
    }
}
