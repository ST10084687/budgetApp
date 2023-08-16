using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetAppNew
{
    abstract class Expenses
    {


        private double finalExpenses = 0;
        //collection of expenses
        private List<double> expenses = new List<double>();

        //populates the differant expendatures in the array
        public void setExpenses(List<double> usersExpenses)
        {
            expenses = usersExpenses;


        }
        //calculates expenses
        public double getTotalExpense()
        {
            //gets total from list
            finalExpenses = expenses.Sum();
            return finalExpenses;
        }
       

        }
    }

