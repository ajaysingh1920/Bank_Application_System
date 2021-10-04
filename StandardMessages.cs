using System;
using System.Collections.Generic;
public class StandardMessages{
    public static void Welcome(){
        Console.WriteLine("Welcome to Banking System:");
    }
    public static void EnterUserName(){
        Console.WriteLine("Enter your username:");
    }
    public static void EnterPassword(){
        Console.WriteLine("Enter your password:");
    }
    public static void EnterAmount(){
        Console.WriteLine("Enter the amount:");
    }
    public static void Display(Account a){
        Console.WriteLine("You are currently having "+a.amount+" rs into your account");
        Console.WriteLine();
    }
    public static void Choice(){
                Console.WriteLine("Create an account-1");
                Console.WriteLine("Deposit-2");
                Console.WriteLine("WithDraw-3");
                Console.WriteLine("Transfer-4");
                Console.WriteLine("Transaction History-5");
                Console.WriteLine("Quit-6");
    }

}