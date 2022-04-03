namespace ATM;
using System.Collections.Generic;
using System.Collections;
using System;

// Interface for the Login
public interface IEnumerable<T>
{

}
public interface DataLogin
{
    bool LoginCheck(string username, int PINCode);

}
// Interface for the Options
public interface options
{
    void AccountActivity();

}
// Inheirtance for the interface to this class
public class Class1 : DataLogin
{
    // Login check with the username and Code
    public bool LoginCheck(string username, int PINCode)
    {
        if (username == "Marco Andres Barreno" && PINCode == 233702)
        {
            return true;

        }
        else
        {

            return false;

        }
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

public class Withdrawal
{
    private Withdrawal _Balance;

    public Withdrawal Balance
    {
        get { return _Balance; }
        set { _Balance = value; }

    }


}
public class WithdrawalPayments : IEnumerable<Withdrawal>
{
    public decimal Balance;
    public decimal ATMCash;

    public decimal result;
    public string _Errors;

    public Withdrawal? Balance1;

    public Withdrawal? Error;
    public Withdrawal Check;

    public Withdrawal GetError()
    {

        return Error;
    }
    public Withdrawal GetBalance()
    {

        return Balance1;


    }
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
    public string Mistake
    {
        get
        {
            return _Errors;

        }
        set
        {
            _Errors = value;
        }
    }


}
