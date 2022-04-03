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
