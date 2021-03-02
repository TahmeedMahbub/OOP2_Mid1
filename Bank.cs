using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid1
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;
        private int i;
        //private int[] myBank;

        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }

        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public Account[] Accounts //returning the array
        {
            set { this.myBank[i] = value; }
            get { return this.myBank; }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                myBank[i].ShowAccountInformation();
            }
        }
    }
}
