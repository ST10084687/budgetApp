using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace budgetAppNew
{
    class Program
    {
        private static double grossMonthlyIncome;
        private static double monthlyTaxDeducted;
        private static List<double> expenses = new List<double>();
        private static double finalExpenses;
        private static double rentCosts;
        private static double homeLoanRepayments;
        private static double availableMonthlyMoney;





        public static void Main(string[] args)
        {
            //Method for splash screen
            splashScreen();
            //Console.WriteLine();

            //Console.WriteLine("==================================");

            //method to get income and tax
            Input();
            Console.WriteLine("==================================");

            //method to get expenses from user
            userEntersExpenses();
            Console.WriteLine("==================================");

            //method to display expenses
            displayExpenses();
            Console.WriteLine("==================================");



            //method for renting or buying
            rentingOrBuying();
            Console.WriteLine("==================================");

            //method to get your available funds
            availableMoney();
            Console.WriteLine("==================================");











            void splashScreen()
            {

                //Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Loading . . . . ");


                //count backwards
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(500);
                }

                Console.WriteLine("\n \n==================================");
                Console.WriteLine("Welcome to Budget Planner App");
                Console.WriteLine("==================================");
                Thread.Sleep(500); //MAX 5000
            }


        }
        static void Input()
        {
            //to keep writing as white
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("INCOME AND TAX: ");

            //getting user input
            Console.Write("Please enter your Gross Monthly Income(before deductions): ");
            grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            //getting user input
            Console.Write("Please enter your Estimated Monthly Tax Deducted: ");
            monthlyTaxDeducted = Convert.ToDouble(Console.ReadLine());


            Console.ReadLine();
        }

        static void userEntersExpenses()
        {
            Console.WriteLine("INPUT EXPENSES: ");
            //getting user input
            Console.Write("\nPlease enter your Monthly Expenditure on Groceries: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));

            //getting user input
            Console.Write("\nPlease enter your Monthly Expenditure on Water and Lights: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));
            //getting user input
            Console.Write("\nPlease enter your Monthly Expenditure on Travel Costs: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));
            //getting user input
            Console.Write("\nPlease enter your Monthly Expenditure on Cell Phone and Telephone: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));
            //getting user input
            Console.Write("\nPlease enter your Monthly Expenditure on Other Expenses: ");
            expenses.Add(Convert.ToDouble(Console.ReadLine()));
        }
        static void displayExpenses()
        {
            //method used to save and display the expenses
            Console.WriteLine("EXPENSES: ");

            Console.WriteLine("\nGroceries: " + finalExpenses);
            Console.WriteLine("Water and Lights: " + finalExpenses);
            Console.WriteLine("Travel Costs: " + finalExpenses);
            Console.WriteLine("Cell Phone and Telephone: " + finalExpenses);
            Console.WriteLine("Other Expenses: " + finalExpenses);

        }

        static void rentingAccomodation()

        {
            //create object of rent class
            Rent theExpenses = new Rent();
            theExpenses.setExpenses(expenses);

            //store final expense
            finalExpenses = theExpenses.getTotalExpense();

            //store monthly repayments
            rentCosts = theExpenses.monthlyRentalAmount();



        }
        static void buyingProperty()
        {
            //creates the object from the homeloan class
            HomeLoan theExpenses = new HomeLoan();
            theExpenses.setExpenses(expenses);

            finalExpenses = theExpenses.getTotalExpense();
            //stores monthly repayments
            rentCosts = theExpenses.monthlyRentalAmount();
            //checks the approval of the loan
            theExpenses.approval(grossMonthlyIncome);

            Console.ReadLine();




        }
        static void availableMoney()
        {
            Console.WriteLine("Money available at the end of the month: ");
            //calculation to get available money at the end of the month
            availableMonthlyMoney = grossMonthlyIncome - (homeLoanRepayments + monthlyTaxDeducted + finalExpenses);
            Console.WriteLine("Available Monthly Money: " + availableMonthlyMoney);
            Console.ReadLine();
        }



        static void rentingOrBuying()
        {

            Console.WriteLine("Type of accomodation: ");
            //message to pick accomodation
            Console.Write("\n Enter 1 if you will be RENTING accomodation or Enter 2 if you will be BUYING a property: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //choice 1 for renting
            if (choice == 1)
            {

                rentingAccomodation();
            }
            //choice 2 for buying
            else if (choice == 2)
            {
                buyingProperty();


            }

        }
       
    }
}
