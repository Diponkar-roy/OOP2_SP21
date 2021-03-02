
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Association_HAS_A_Relation__A_
{
    class Account
    {
        //private int accountNumber= new Random().Next(1000, 2000);
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation
        //private string GenerateUniqueID;



        public Account(int accountNumber, string accountName, double balance, Address address)     //int accountNumber,
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }


        public int AccountNumber
        {

            set { this.accountNumber = value; }
            get
            {
                return this.accountNumber;

            }
        }




        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }





        public double doWithdrawl()
        {
            balance -= balance;

            if (balance < 0)
            {
                throw new ArgumentException("Withdrawing " + balance.ToString("C") + " would leave you overdrawn!");
            }
            return balance;
        }


        public double doDeposit()
        {
            balance += balance;
            return balance;
        }


       



        public void PrintAccount()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }




        //public bool TransferFunds(int fromAccountId, int toAccountId, decimal transferAmount)
        //{
        //    if (transferAmount <= 0)
        //    {
        //        throw new ApplicationException("transfer amount must be positive");
        //    }
        //    else if (transferAmount == 0)
        //    {
        //        throw new ApplicationException("invalid transfer amount");
        //    }

        //    Account fromAccount = GetAccount(fromAccountId);
        //    Account toAccount = GetAccount(toAccountId);

        //    if (fromAccount.balance < transferAmount)
        //    {
        //        throw new ApplicationException("insufficient funds");
        //    }

        //    fromAccount.Transfer(-1 * transferAmount, toAccountId);
        //    toAccount.Transfer(transferAmount, fromAccountId);

        //    return true;
        //}


    }
}







//int flag = 0;
//for (int i = 0; i < _id.Length; i++)
//{
//    if (myBank[i] == null)
//    {
//        continue;
//    }
//    else if (myBank[i].AccountNumber == accountNo)
//    {
//        //accounts[i].PrintAccount();
//        flag = 0;
//        for (int j = i; j < (myBank.Length - 1); j++)
//        {
//            if (j < myBank.Length - 1)
//            {
//                myBank[j] = null;
//                myBank[j] = myBank[j + 1];

//            }
//            else
//            {
//                myBank[j] = null;
//            }
//        }
//        Console.WriteLine("This account has been deleted");
//        Console.WriteLine("..............................");
//        //Console.WriteLine("New List......................");
//        break;
//    }
//    else
//    {
//        flag = 1;

//    }
//}
//if (flag == 1)
//    Console.WriteLine("Account Not Found");

