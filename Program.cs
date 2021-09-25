using System;
using System.Collections.Generic; 

namespace myproject
{
    class Program
    {
        static Dictionary<string,Account> info;

        public static Account credentialCheck(){
               Console.WriteLine("Enter the username:");
               string username=Console.ReadLine();
               while(info.ContainsKey(username)==false){
                   Console.WriteLine("Username doesn't exist,please write correct username");
                   username=Console.ReadLine();
               }
               Console.WriteLine("Enter the password");
               string password=Console.ReadLine();
               Account a=info[username];
               while(a.password!=password){
                  Console.WriteLine("Please enter the correct password");
                  password=Console.ReadLine();
               }
               return a;
        }

        public static void transactionHistory(){
            Account a=credentialCheck();
            Stack<String> st=a.transactionHistory;
            foreach (string str in st)  
            {  
                Console.WriteLine(str);  
            }  
            Console.WriteLine();
        }

        public static void transfer(){
             Account a=credentialCheck();
             Console.WriteLine("Enter the username of the account in which you want to transfer");
             string username=Console.ReadLine();
             while(info.ContainsKey(username)==false){
                 Console.WriteLine("Username doesn't exist,please enter the correct username");
                 username=Console.ReadLine();
             }
             Account b=info[username];           

             Console.WriteLine("Enter the amount you want to transfer");
             int amount=Convert.ToInt32(Console.ReadLine());
             while(amount>a.amount){
                 Console.WriteLine("You only have "+a.amount+" Rs");
                 amount=Convert.ToInt32(Console.ReadLine());
             }
            
             b.amount+=amount;
             a.amount-=amount;

             Console.WriteLine("Rs "+amount+" has been transferred to "+ username);
             Stack<string> sta=a.transactionHistory;
             sta.Push("Rs "+amount+" has been transferred from your account");
             Stack<String> stb=b.transactionHistory;
             stb.Push("Rs "+amount+" has been transferred into your account");
             Console.WriteLine("You are currently having "+a.amount+" rs into your account");
             Console.WriteLine();
        }

        public static void withdraw(){
            Account a=credentialCheck();
            Console.WriteLine("Enter the amount you want to withdraw:");
            int amount=Convert.ToInt32(Console.ReadLine());
            while(amount>a.amount){
                Console.WriteLine("You only have "+a.amount+" Rs");
                amount=Convert.ToInt32(Console.ReadLine());
            }
            a.amount-=amount;
            Console.WriteLine("Rs "+amount+" has been withdraw from your account");
            Stack<String> st=a.transactionHistory;
            st.Push("Rs "+amount+" has been withdraw from your account");
            Console.WriteLine("You are currently having "+a.amount+" rs into your account");
            Console.WriteLine();
        }

        public static void deposit()  
        {  
              Account a=credentialCheck();
              Console.WriteLine("Enter the amount");
              int amount=Convert.ToInt32(Console.ReadLine());
              a.amount+=amount;
              Stack<String> st=a.transactionHistory;
              st.Push("Rs "+amount+" has been deposited into your account");
              Console.WriteLine("Rs "+amount+" has been deposited into you account");
            //   Console.WriteLine(a.amount);
                Console.WriteLine("You are currently having "+a.amount+" rs into your account");
                Console.WriteLine();
        }  

        public static void create(){
            Console.WriteLine("Enter the username:");
            string username=Console.ReadLine();
            // Console.WriteLine(info.ContainsKey(username));
            while(info.ContainsKey(username)==true){
                Console.WriteLine("username already exist,Please enter the unique username");
                username=Console.ReadLine();
            }
            Console.WriteLine("Enter the password");
            string password=Console.ReadLine();
            Account a=new Account(password);   
            info.Add(username,a);
            Console.WriteLine("Account with the username "+ username+" has been created");
            Console.WriteLine("You are currently having "+a.amount+" rs into your account");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            info=new Dictionary<string,Account>();
            Console.WriteLine("Welcome to Banking System");
            int choice=0;
            while(choice!=6){
                Console.WriteLine("Create an account-1");
                Console.WriteLine("Deposit-2");
                Console.WriteLine("WithDraw-3");
                Console.WriteLine("Transfer-4");
                Console.WriteLine("Transaction History-5");
                Console.WriteLine("Quit-6");
                choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        create();
                        break;
                    case 2:
                        deposit();
                        break;
                    case 3:
                        withdraw();
                        break;
                    case 4:
                        transfer();
                        break;
                    case 5:
                        transactionHistory();
                        break;
                    case 6:
                        break;
                    default:
                        break;
                }
            }
         }
    }
}
