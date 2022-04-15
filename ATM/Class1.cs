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
    bool LoginCheck(string username, string PINCode);

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
    public bool LoginCheck(string username, string PINCode)
    {
        if (ChangePIN.Equals(""))
        {
            ChangePIN = "233702";
        }
        
        var prime = Tuple.Create("Marco Andres Barreno", ChangePIN);

        if (username == prime.Item1 && PINCode == prime.Item2)
        {
            return true;

        }
        else
        {

            return false;

        }
    }
    public void ChangingPin()
    {
        Console.WriteLine("Change the new PIN (must be a Pin of 6 Digits)");
        string firstTryTipingPin = Console.ReadLine();
        Console.WriteLine("Re-enter the PIN Changed");
        string confirmationPIN = Console.ReadLine();
        if(firstTryTipingPin.Equals(confirmationPIN) )
        {
            ChangePIN = firstTryTipingPin;
            Console.WriteLine("-----------------------Your Pin Has Been Changed-------------------");
        }
        else
        {
            Console.WriteLine("----------Error in the confirmation of your credentials----------------");
        }
    }


    public object LoginCheck()
    {
        throw new NotImplementedException();
    }

    // Balance method, knowing the first balance
    public int Balance(int pay)
    {
        int balance = 800;
        balance = balance - pay;
        return balance;
    }


}
// Inheritance from the class and from the interface
public class OptionMenu : Class1, options
{

    public void AccountActivity()
    {
        Console.WriteLine("-----ACCOUNT ACTIVITY--------------------");
        Console.WriteLine("Maverick...................." + " -" + 20);
        Console.WriteLine("Snow ATM...................." + " -" + 200);
        Console.WriteLine("Walmart....................." + " -" + 60);
        int pay = 20 + 200 + 60;
        Console.WriteLine("Actual Balance -------- " + Balance(pay) + "--------");


    }
}
// Class with withdrawal
public class Withdrawal
{
    // Balance set
    private Withdrawal _Balance;

    // return from balance
    public Withdrawal Balance
    {
        get { return _Balance; }
        set { _Balance = value; }

    }


}
// IEnumerable Inheritance with <Withdrawal>
public class WithdrawalPayments : IEnumerable<Withdrawal>
{
    public decimal Balance;
    public decimal ATMCash;

    public decimal result;
    public string _Errors;

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
