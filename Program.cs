
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid1
{

    class Program
    {
        string o;
        static void Main(string[] args)
        {
            Console.Write("1. add acc:\n2. delete acc \n3. withdraw\n4. deposit \n5. transfer\n6. show acc info\n\n\nwhat do you want:");
            string o = Console.ReadLine();
            int opt = Int32.Parse(o);


            switch (opt)
            {
                case 1:
                    Account a1 = new Account();
                    o = Console.ReadLine();
                    a1.AccountName();
                    a1.AccountNumber();
                    a1.Address();

                    break;
                case 2:
                    Console.WriteLine("Coder is noob. He can't delete it!");
                    break;
                case 3:
                    Account a2 = new Account();
                    Console.WriteLine("enter amount: ");
                    o = Console.ReadLine();
                    double amount = Convert.ToDouble(o);
                    a2.Withdraw(amount);
                    break;
                case 4:
                    Account a3 = new Account();
                    Console.WriteLine("enter amount: ");
                    o = Console.ReadLine();
                    amount = Convert.ToDouble(o);
                    a3.Deposit(amount);
                    break;
                case 5:
                    Account a4 = new Account();
                    Console.WriteLine("enter reciever's account: ");
                    string r = Console.ReadLine();
                    int rec = Int32.Parse(r);
                    Console.WriteLine("enter amount: ");
                    o = Console.ReadLine();
                    amount = Convert.ToDouble(o);
                    a4.Transfer(rec, amount);
                    break;
                case 6:
                    Account a5 = new Account();
                    a5.ShowAccountInformation();
                    break;
                /*case 7:
                    Console.WriteLine("Sunday");
                    break;*/
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }


        }
    }
}