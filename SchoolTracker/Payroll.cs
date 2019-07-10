using System;
using System.Collections.Generic;

namespace SchoolTracker
{

    interface IPayee
    {
        void Pay();
    }

    class Payroll
    {
        List<IPayee> payees = new List<IPayee>();
       

        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

        }

        public void payAll()
        {
            foreach (var item in payees)
            {
                item.Pay();
            }
        }
    }
}
