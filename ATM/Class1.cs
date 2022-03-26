namespace ATM;
// Interface for the Login
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
        else{

            return false;

        }
    }
    // Balance method, knowing the first balance
    public int Balance(int pay){
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
        int pay = 20 + 200 +60;
        Console.WriteLine("Actual Balance -------- " + Balance(pay) + "--------");
        
        
    }
}