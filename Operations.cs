using System;
using System.Collections.Generic;

public class Operations{
         public static void Create(Dictionary<string,Account> info){
            StandardMessages.EnterUserName();
            string username=Console.ReadLine();
            while(info.ContainsKey(username)==true){
                Console.WriteLine("username already exist,Please enter the unique username");
                username=Console.ReadLine();
            }
            StandardMessages.EnterPassword();
            string password=Console.ReadLine();
            Account a=new Account(password);   
            info.Add(username,a);
            Console.WriteLine("Account with the username "+ username+" has been created");
            StandardMessages.Display(a);
        }  
        public static void Deposit(Dictionary<string,Account> info)  
        {  
              Account a=UserValid.UserValidation(info);
              StandardMessages.EnterAmount();
              int amount=Convert.ToInt32(Console.ReadLine());
              a.amount+=amount;
              Stack<String> st=a.transactionHistory;
              st.Push("Rs "+amount+" has been deposited into your account");
              Console.WriteLine("Rs "+amount+" has been deposited into your account");
              StandardMessages.Display(a);
        }  
        public static void TransactionHistory(Dictionary<string,Account> info){
            Account a=UserValid.UserValidation(info);
            Stack<String> st=a.transactionHistory;
            foreach (string str in st)  
            {  
                Console.WriteLine(str);  
            }  
            Console.WriteLine();
        }
        public static void WithDraw(Dictionary<string,Account> info){
            Account a=UserValid.UserValidation(info);
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
            StandardMessages.Display(a);
            Console.WriteLine();
        }
          public static void Transfer(Dictionary<string,Account> info){
            Account a=UserValid.UserValidation(info);
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
             StandardMessages.Display(a);
             Console.WriteLine();
    }
}