using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetAppNew
{
     class HomeLoan : Expenses
    {
        private double price;
        private double deposit;
        private double interestRate;
        private double monthsToPay;
        private double homeLoanRepayments;
        private double availableMonthlyMoney;

        public double monthlyRentalAmount()
        {
            double totalAmount;
            double years;
            double amountOwed;

            //prompts for price
            Console.Write("Please enter the Purchase Price of the Property: ");
            price = Convert.ToDouble(Console.ReadLine());

            //prompts for deposit
            Console.Write("Please enter the Total Deposit: ");
            deposit = Convert.ToDouble(Console.ReadLine());

            //prompts for interest rate
            Console.Write("Please enter the Interest Rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            //prompts for months to pay
            Console.Write("Please enter the Number of Months to Repay(240 or 360): ");
            monthsToPay = Convert.ToDouble(Console.ReadLine());

            //this calculation is performed using the formula: A + P(1+(i * n))
            totalAmount = price - deposit;
            interestRate = interestRate / 100;
            years = monthsToPay / 12;

            //full calculation using formula
            amountOwed = totalAmount * (1 + (interestRate * years));

            //monthly repayments calculation
            homeLoanRepayments = amountOwed / monthsToPay;
            //rounds off to 2 decimals
            homeLoanRepayments = Math.Round(homeLoanRepayments, 2);

            Console.WriteLine("\n==================================");


            Console.WriteLine("The Monthly Home Loan Repayment for buying a house is: " + homeLoanRepayments);
            Console.ReadLine();

            return homeLoanRepayments;

           
        }
       // method to see if the loan will be approved
        public void approval(double grossMonthlyIncome)
        {
            if ((grossMonthlyIncome / 3) < homeLoanRepayments)
            {
                
                Console.WriteLine("ALERT!!! >>> THE APPROVAL OF THE LOAN IS UNLIKELY");
                
                Console.ReadLine();
            }



        }






    }


    }

