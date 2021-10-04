using System;
using System.Collections.Generic; 

namespace myproject
{
  class Program
    {
        static Dictionary<string,Account> info;
 
        static void Main(string[] args)
        {
            info=new Dictionary<string,Account>();
            StandardMessages.Welcome();
            int choice=0;
            while(true){
                StandardMessages.Choice();
                choice=Convert.ToInt32(Console.ReadLine());
                bool check=true;
                switch (choice)
                {
                    case 1:
                        Operations.Create(info);
                        break;
                    case 2:
                        Operations.Deposit(info);
                        break;
                    case 3:
                        Operations.WithDraw(info);
                        break;
                    case 4:
                        Operations.Transfer(info);
                        break;
                    case 5:
                        Operations.TransactionHistory(info);
                        break;
                    default:
                        check=false;
                        break;
                }
                if(check==false) break;
            }
         }
    }
}
