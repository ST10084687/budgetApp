using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetAppNew
{

    class Rent : Expenses

    {
        
        private double rentalAmount;

        //constructor
        public Rent()
        {
            

        }

        
        //method sets monthly repayments 
         public double monthlyRentalAmount()
        {
            Console.WriteLine("Please enter the Monthly Rental Amount: ");
            rentalAmount = Convert.ToDouble(Console.ReadLine());
            return rentalAmount;
        }
    }
}
