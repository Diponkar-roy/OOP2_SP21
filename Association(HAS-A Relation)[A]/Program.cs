using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Association_HAS_A_Relation__A_;

namespace Association_HAS_A_Relation__A_
{
    class Program
    {

        static void Main(string[] args)
        {


            //Random rng = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(GenerateDigit(rng));
            //}


            //Address address1 = new Address(4,10,"Dhaka");
            //Account account1 = new Account(1001, "Shakib", 2000, address1);
            //account1.PrintAccount();

            //Account account2 = new Account(1002,"Tamim",3000,new Address(7,20,"Chittagong"));
            //account2.PrintAccount();




            Bank ourBank = new Bank("DBBL", 10);
            ourBank.AddAccount(new Account(5560,"Rakib", 10000, new Address("20", "15", "Dhaka","Bangladesh")));
            ourBank.AddAccount(new Account(7802, "Saiful", 80000, new Address("28", "10", "Sylhet", "Bangladesh")));
            ourBank.AddAccount(new Account(9258, "Shamim", 2000, new Address("30","5", "Chittagong","Bangladesh")));
            
           



            Console.WriteLine("1. All Account ");
            Console.WriteLine("2. Withdraw ");
            Console.WriteLine("3. Deposit ");
            Console.WriteLine("4. Transfer ");
            Console.WriteLine("5. Add_Account ");
            Console.WriteLine("6. Delete_Account ");
            Console.WriteLine("7. Transaction ");
            Console.WriteLine("      ");
            Console.WriteLine("Enter the Number: ");
            int num = System.Convert.ToInt32(Console.ReadLine());

            if (num == 1)                            
            {
                Console.WriteLine("      ");
                ourBank.PrintAllAccounts();
            }

            if (num == 2)                          
            {
                Console.WriteLine("Enter the Account Number: ");
                int acnumber = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Amount : ");
                double taka = System.Convert.ToDouble(Console.ReadLine());
                
             
            }

            else if(num ==3)                     
            {
                Console.WriteLine("      ");
                Console.WriteLine("Please give your Account number:");
                int acnumber = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please give your deposite amount:");
                int _amount = System.Convert.ToInt32(Console.ReadLine());

            }
            else if (num == 4)            
            {
                Console.WriteLine("      ");
            }
            else if (num == 5)               
            {
                Console.WriteLine("      ");
                ourBank.PrintAddAccount();
                


            }
            else if (num == 6)                     
            {
                Console.WriteLine("      ");
                Console.WriteLine("Enter Account Number");
                int acnumber = System.Convert.ToInt32(Console.ReadLine());
                ourBank.DeleteAccount(acnumber);
                

            }
            else if (num == 7)                  
            {
                Console.WriteLine("      ");
               
            }


        }
    }
}
