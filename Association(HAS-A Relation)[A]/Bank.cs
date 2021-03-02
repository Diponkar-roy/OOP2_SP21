using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Association_HAS_A_Relation__A_
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;//1-* Relation
        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }
        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] Accounts
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }









        public void PrintAddAccount()
        {
            Bank ourBank = new Bank("DBBL", 5);
            Console.WriteLine("      ");
            Console.WriteLine("Account Number: ");
            int acountnumber = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Account Holdername: ");
            string name = Console.ReadLine();
            int balance = 0;
            Console.WriteLine("House No: ");
            string houseNo = Console.ReadLine();
            Console.WriteLine("Road No:  ");
            string rodNo = Console.ReadLine();
            Console.WriteLine("City Name: ");
            string CityName = Console.ReadLine();
            Console.WriteLine("Country Name: ");
            string CountryName = Console.ReadLine();
            ourBank.AddAccount(new Account(acountnumber, name, balance, new Address(houseNo, rodNo, CityName, CountryName)));
            Console.WriteLine("      ");
            Console.WriteLine("Your Account has been updated ");

        }




        public void DeleteAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNo)
                {
                    //accounts[i].PrintAccount();
                    flag = 0;
                    for( int j=i; j<(myBank.Length-1); j++)
                    {
                        if(j< myBank.Length-1)
                        {
                            myBank[j] = null;
                            myBank[j] = myBank[j+1];
                            
                        }
                        else
                        {
                            myBank[j] = null;
                        }
                    }
                    Console.WriteLine("This account has been deleted");
                    Console.WriteLine("..............................");
                    //Console.WriteLine("New List......................");
                    break;
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }


    }
}
