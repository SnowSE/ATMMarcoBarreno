﻿namespace ATM;
public class Program
{
    public static void Main (string[]args){

   

    Console.WriteLine("-------SNOW COLLEGE BANK-------");

    Console.WriteLine("Insert your username");

    string username; 

    username = Console.ReadLine();
    

    Console.WriteLine("Insert the PIN");

    int PINCode = (Int32.Parse(Console.ReadLine()));
    Class1 obj = new Class1();

    if (obj.LoginCheck(username, PINCode)== true)
    {
    Menus s = new Menus();
    s.PrincipalMenu();
    }

    if (obj.LoginCheck(username, PINCode)==false)
    {
    Console.WriteLine("Invalid Credentials...................");
    }

    }    
}
public class Menus
{
    public void PrincipalMenu()
    {
        Console.WriteLine("Hi Marco");
        Console.WriteLine("Select an option.....");
        Console.WriteLine("1. Account Actvity, Balances, Updates       2. Cash Withdrawal");
        Console.WriteLine("3. Payment & Transfers                      4. Set my favourite Withdrawal");
        Console.WriteLine("5. Change PIN                               6. Deposit");
        int Select = Int32.Parse(Console.ReadLine());
        switch (Select)
        {
            case 1:
            SelectionAccountActivity();
            break;

            case 2:
            CashWithdrawal();
            break;

            case 3:
            PayTrans();
            break;

            case 4:
            SetMyFavouriteWithdrawal();
            break;

            case 5:
            ChangePIN();
            break;

            case 6:
            Deposit();
            break;

        }
    }
    public void SelectionAccountActivity()
    {

    }
    public void CashWithdrawal()
    {

    }
    public void PayTrans()
    {

    }
    
    public void SetMyFavouriteWithdrawal()
    {

    }
    public void ChangePIN()
    {
        
    }
    public void Deposit()
    {

    }
}
