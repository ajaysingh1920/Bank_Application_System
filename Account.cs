using System;
using System.Collections.Generic;
public class Account{
    public string password;
    public int amount;
    public  Stack<string> transactionHistory;
    
    public Account(string password){
        this.password=password;
        amount=0;
        transactionHistory=new Stack<String>();
    }
    
}