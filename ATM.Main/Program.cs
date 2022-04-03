namespace ATM;
public class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("-------SNOW COLLEGE BANK-------");

        Console.WriteLine("Insert your username");

        //Declaring username and PIN
        string username;

        username = Console.ReadLine();

        Console.WriteLine("Insert the PIN");

        int PINCode = (Int32.Parse(Console.ReadLine()));
        //Object for LoginCheck of username and PIN inheirtance from Class1
        Class1 obj = new Class1();

        if (obj.LoginCheck(username, PINCode) == true)
        {
            Menus s = new Menus();
            Console.WriteLine("---------ACCEPTED---------");
            s.PrincipalMenu();
        }

        if (obj.LoginCheck(username, PINCode) == false)
        {
            Console.WriteLine("Invalid Credentials...................");
        }

    }
}
public class Menus
{
    //Principal Menu Method
    public void PrincipalMenu()
    {

        Console.WriteLine("Hi Marco");
        Console.WriteLine("Select an option.....");
        Console.WriteLine("1. Account Actvity, Balances, Updates       2. Cash Withdrawal");
        Console.WriteLine("3. Payment & Transfers                      4. Set my favourite Withdrawal");
        Console.WriteLine("5. Change PIN                               6. Deposit");
        int Select = Int32.Parse(Console.ReadLine());
        // Menu options & connection to their methods
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
    // Option Methods
    public void SelectionAccountActivity()
    {
        OptionMenu ob = new OptionMenu();
        ob.AccountActivity();
        Console.WriteLine("Would you like to make another transaction --- Yes or No  y/n");

        try
        {

            Check(Console.ReadLine());

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }


    }
    public void CashWithdrawal()
    {

        WithdrawalPayments eq = new WithdrawalPayments();
        decimal Balance = 800;
        Console.WriteLine("Insert the amount you want to withdraw in cash");
        decimal ATMCash = Convert.ToDecimal(Console.ReadLine());
        eq.GetEnumerator(Balance, ATMCash);
        if (eq.Check == eq.GetError() && Balance < ATMCash)
        {
            Console.WriteLine("your balance is not enough");
        }
        if (eq.Check == eq.GetBalance() && Balance > ATMCash)
        {
            Console.WriteLine("-------Processing--------");
            Console.WriteLine("--------Complete---------");
            Console.WriteLine("Retire your money");

        }
    }


    public void PayTrans()
    {
        Transaction e = new Transaction();
        Console.WriteLine("Insert the routing number");
        int routing = Int32.Parse(Console.ReadLine());
        e.RoutingNumber(routing);
        Console.WriteLine("Insert the account number");
        int account = Int32.Parse(Console.ReadLine());
        e.AccountNumber(account);
        int balance = 800;
        Console.WriteLine("Insert the amount you want to transfer");
        int amount = Int32.Parse(Console.ReadLine());
        e.Payment(balance, amount);
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

    // Continue & Check Method, Each Option need to have this until close the program
    public bool Check(string check)
    {

        if (check == "y")
        {
            Menus s = new Menus();
            s.PrincipalMenu();
            return true;

        }
        else
        {
            return false;
        }

    }
}
