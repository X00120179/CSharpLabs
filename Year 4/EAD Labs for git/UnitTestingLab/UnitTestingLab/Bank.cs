// Lee Healy X00120179
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingLab
{
    // Bank Account.
    public class BankAccount
    {
        // Fields.
        private String sortCode;
        private String accountNumber;
        private double overdraftLimit;
        private double balance;

        // Keep track of transaction history (Positive amount are deposits/Negative amounts are withdrawals).
        private List<double> transactionHistory; // Records desposits and withdrawals.

        // Read-Only Properties.

        // SortCode Property.
        public String SortCode
        {
            get
            {
                return sortCode;
            }
        }
        
        // AccountNumber Property.
        public String AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        // OverdraftLimit Property.
        public double OverdraftLimit
        {
            get
            {
                return overdraftLimit;
            }
        }

        // Balance Property.
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        // Transaction History Property
        public List<double> TransactionHistory
        {
            get
            {
                return transactionHistory;
            }
        }
   

        // Constructor.
        public BankAccount(String sortCodeIn, String accountNumberIn, double overdraftLimitIn)
        {
            if (overdraftLimitIn >= 0) //
            {
                this.sortCode = sortCodeIn;
                this.accountNumber = accountNumberIn;
                this.overdraftLimit = overdraftLimitIn;
                this.balance = 0; // Opening balance of a new account is zero.

                transactionHistory = new List<double>();

            } else
            {
                throw new ArgumentException("Over draft limit must be greater than or equal to zero.");
            }
        }

        // Overload Constructor.
        public BankAccount(String sortCodeIn, String accountNumberIn) : this(sortCodeIn, accountNumberIn, 0)
        {
           
        }

        // Deposit Method.
        public void Deposit(double amountIn)
        {
            if (amountIn > 0)
            {
                balance += amountIn;
                // Recording deposit in transaction history.
                transactionHistory.Add(amountIn);
            } else
            {
                throw new ArgumentException("You must deposit an amount at least greater than zero.");
            }
        }

        // Withdraw Method.
        public void Withdraw(double amountIn)
        {
            if(amountIn > 0)
            {
                if((balance + overdraftLimit) > amountIn)
                {
                    balance -= amountIn;
                    // Recording withdrawal in transaction hsitory.
                    transactionHistory.Add(amountIn * -1);
                } else
                {
                    throw new ArgumentException("Insufficient funds.");
                }
            } else
            {
                throw new ArgumentException("The amount you want to withdraw must be at least greater than zero.");
            }
        }

        // Overriding ToString() method.
        public override string ToString()
        {
            String output = "\nSort code:\t" + sortCode + "\nAccount No:\t" + accountNumber + "\nOverdraft Limit:\t" + overdraftLimit + "\nBalance:\t" + balance + "\n";
            output += "\nTransaction History:\n";
            foreach(double trans in transactionHistory)
            {
                output = + trans + " ";
            }
            return output;
        }
    }

    public class TestClass
    {

        public static void Main()
        {

        }
    }

   
}
