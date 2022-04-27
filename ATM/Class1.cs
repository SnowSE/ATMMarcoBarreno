namespace ATM;
using System.Collections.Generic;
using System.Collections;
using System;

// Interface for IEnumerable with <T>
public interface IEnumerable<T>
{

}
// Interface for the Login
public interface DataLogin
{
    bool LoginCheck(string usernameCheck, string PINCodeCheck, string username, string PINCode);

}
// Interface for the Options
public interface options
{
    void AccountActivity();

}
// Inheirtance for the interface to this class
public class Class1 : DataLogin
{

    public static string ChangePIN = "";
    // Login check with the username and Code

    public bool LoginCheck(string usernameCheck, string PINCodeCheck, string username, string PINCode)
    {


        var prime = Tuple.Create(usernameCheck, PINCodeCheck);

        if (username == prime.Item1 && PINCode == prime.Item2)
        {
            return true;

        }
        else
        {

            return false;

        }
    }
    public string ChangingPin(string ChangePIN)
    {

        Console.WriteLine("Change the new PIN (must be a Pin of 6 Digits)");
        string firstTryTipingPin = Console.ReadLine();
        Console.WriteLine("Re-enter the PIN Changed");
        string confirmationPIN = Console.ReadLine();

        if (firstTryTipingPin.Equals(confirmationPIN))
        {
            ChangePIN = firstTryTipingPin;
            Console.WriteLine("-----------------------Your Pin Has Been Changed------------------- is " + ChangePIN);
            return ChangePIN;
        }
        else
        {
            Console.WriteLine("----------Error in the confirmation of your credentials----------------");
            ChangingPin(ChangePIN);
            return ChangePIN;
        }

    }
    public string UsernameSetChangingPin(string username, string userset)
    {
        username = userset;
        return username;
    }


    public object LoginCheck()
    {
        throw new NotImplementedException();
    }

    // Balance method, knowing the first balance
    public int Balance(int balance, int pay)
    {

        balance = balance - pay;
        return balance;
    }

    public void CreatingAccount(string username, string PINCode)
    {


    }

}
// Inheritance from the class and from the interface
public class OptionMenu : Class1, options
{
    Menus m = new Menus();

    public void AccountActivity()
    {

        Console.WriteLine("-----ACCOUNT ACTIVITY--------------------");
        Console.WriteLine("Maverick...................." + " -" + 20);
        Console.WriteLine("Snow ATM...................." + " -" + 200);
        Console.WriteLine("Walmart....................." + " -" + 60);
        int pay = 20 + 200 + 60;
        Console.WriteLine("Actual Balance -------- " + Balance(m.Balance(), pay) + "--------");


    }
}
// Class with withdrawal
public class Withdrawal
{
    // Balance set



}
// IEnumerable Inheritance with <Withdrawal>
public class WithdrawalPayments : IEnumerable<Withdrawal>
{


    public decimal result;


    public Withdrawal? Balance1;

    public Withdrawal? Error;
    //Check for ATM 
    public Withdrawal Check;
    //Check if there is an error
    public Withdrawal GetError()
    {

        return Error;
    }
    //Check for the balance
    public Withdrawal GetBalance()
    {

        return Balance1;


    }
    //Get the enumerator referencing to IEnumerator with the two decimal arguments
    public IEnumerator<Withdrawal> GetEnumerator(decimal Balance, decimal ATMCash)
    {
        if (Balance < ATMCash)
        {
            Check = GetError();


        }

        if (Balance > ATMCash)
        {
            Balance = Balance - ATMCash;
            result = Balance;
            Check = GetBalance();


        }
        yield return Check;
    }

}
