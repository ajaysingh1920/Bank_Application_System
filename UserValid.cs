using System;
using System.Collections.Generic;

public class UserValid{
    public static Account UserValidation(Dictionary<string,Account> info){
               StandardMessages.EnterUserName();
               string username=Console.ReadLine();
               while(info.ContainsKey(username)==false){
                   Console.WriteLine("Username doesn't exist,please write correct username");
                   username=Console.ReadLine();
               }
               StandardMessages.EnterPassword();
               string password=Console.ReadLine();
               Account a=info[username];
               while(a.password!=password){
                  Console.WriteLine("Please enter the correct password");
                  password=Console.ReadLine();
               }
               return a;
        }
}