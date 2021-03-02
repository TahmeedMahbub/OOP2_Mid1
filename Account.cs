using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid1
{
    class Account
    {
        private int m = 0;
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        //declaring parameterized constructor
        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance; // storing a value
            this.address = address; //storing an obj ref
        }
        public int AccountNumber(int i)
        {

            int accountNumber = m + 1;
            m = accountNumber;
            return accountNumber;
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public void Withdraw(double amount)
        {
            this.balance = this.balance - amount;
        }
        public void Deposit(double amount)
        {
            this.balance = this.balance + amount;
        }
        public void Transfer(double amount, Account reciever)
        {
            if (amount > 0 && amount < this.balance)
            {
                foreach (int reciever in myBank)
                    this.balance = this.balance - amount;
                reciever = reciever + amount;
            }

        }

        public void ShowAccountInformation()
        {
            //Console.WriteLine("Account Number: " + this.accountNumber + "\nAccount Name: " + this.accountName + "\nBalance: " + this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.GetAddress();
        }

    } 
}
