
namespace ATM

{
    public class Menus
    {
        WithdrawalPayments eq = new WithdrawalPayments();
        Balances balanceObject = new Balances();
        Class1 obj = new Class1();

        public static int initialValue = 800;
        public int SelectOption;
        public string username { get; set; }
        public string PINCode { get; set; }
        public int ATMCash;
        public static string userset;
        public string usernameCheck { get; set; }
        public string PINCodeCheck { get; set; }
        public int Balance()
        {
            balanceObject.balance = initialValue;
            return balanceObject.balance;
        }


        public void AccountCheck()
        {
            Console.WriteLine("----------------WELCOME TO SNOW BANK----------------");
            Console.WriteLine("Do you have an account");
            Console.WriteLine("If yes type 'y' if you don't have an acoount type  'n'");
            string selection = Console.ReadLine();
            if (selection == "y")
            {

                Initialize();
            }
            if (selection == "n")
            {
                Console.WriteLine("Insert your username");
                username = Console.ReadLine();
                userset = username;
                
                Console.WriteLine("Insert your PIN");
                PINCode = Console.ReadLine();
                Initialize();
            }

        }
        public void Initialize()
        {
            Console.WriteLine("-------SNOW COLLEGE BANK-------");
            Console.WriteLine("Insert your username");
            //Declaring username and PIN
            usernameCheck = Console.ReadLine();
            Console.WriteLine("Insert the PIN");
            PINCodeCheck = Console.ReadLine();
            //Object for LoginCheck of username and PIN inheirtance from Class1


            if (obj.LoginCheck(usernameCheck, PINCodeCheck, username, PINCode) == true)
            {
                Menus s = new Menus();
                Console.WriteLine("------------ACCEPTED-------------");
                s.PrincipalMenu();
            }

            if (obj.LoginCheck(usernameCheck, PINCodeCheck, username, PINCode) == false)
            {
                Console.WriteLine("Invalid Credentials...................");
                Console.WriteLine("Do you want to try again? y/n.");
                string check = Console.ReadLine();
                if (check == "y")
                {
                    Initialize();

                }
                if (check == "n")
                {
                    Exit();

                }
            }
        }
        //Principal Menu Method
        public void PrincipalMenu()
        {
            Console.WriteLine("Hi" + username);
            Console.WriteLine("");
            Console.WriteLine("Select an option.....");
            Console.WriteLine("1. Account Actvity, Balances, Updates             2. Cash Withdrawal");
            Console.WriteLine("");
            Console.WriteLine("3. Payment & Transfers                            4. Change PIN  ");
            Console.WriteLine("");
            Console.WriteLine("5. Deposit                                        6. Exit");
            SelectOption = Int32.Parse(Console.ReadLine());
            // Menu options & connection to their methods
            switch (SelectOption)
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
                    ChangePIN();
                    break;

                case 5:
                    Deposit();
                    break;
                case 6:
                    Exit();
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
            catch
            {

                Console.WriteLine("Enter a invalid number");
            }


        }
        public void CashWithdrawal()
        {



            Console.WriteLine("Insert the amount you want to withdraw in cash");
            ATMCash = Convert.ToInt32(Console.ReadLine());
            eq.GetEnumerator(Balance(), ATMCash);
            if (eq.Check == eq.GetError() && Balance() < ATMCash)
            {
                Console.WriteLine("your balance is not enough");
            }
            if (eq.Check == eq.GetBalance() && Balance() > ATMCash)
            {
                Console.WriteLine("-------Processing--------");
                Console.WriteLine("--------Complete---------");
                Console.WriteLine("Retire your money");
                Console.WriteLine("Your balance is ... " + obj.Balance(Balance(), ATMCash));
            }
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
        public void PayTrans()
        {
            //Transaction part
            //Creating the object with Transaction in the class paytrans
            Transaction e = new Transaction();
            //Insert the data of the account you want to transfer
            //Insert routing number
            Console.WriteLine("Insert the routing number");
            try
            {
                int routing = Int32.Parse(Console.ReadLine());
                e.RoutingNumber(routing);
            }
            catch
            {
                Console.WriteLine("Insert a valid routing number");

            }

            //Insert account number
            Console.WriteLine("Insert the account number");
            try
            {
                int account = Int32.Parse(Console.ReadLine());
                e.AccountNumber(account);
            }
            catch
            {
                Console.WriteLine("Insert a valid account number");
            }
            //predefined balance

            //The amount to transfer
            Console.WriteLine("Insert the amount you want to transfer");
            try
            {
                int amount = Int32.Parse(Console.ReadLine());
                //object to payment refering to the abstract class 
                e.Payment(Balance(), amount);
            }
            catch
            {
                Console.WriteLine("Insert a valid amount");
            }
            Console.WriteLine("Would you like to make another transaction --- Yes or No  y/n");

            try
            {

                Check(Console.ReadLine());

            }
            catch (Exception m)
            {

                Console.WriteLine(m.Message);
            }
        }

        public void ChangePIN()
        {
            PINCode = obj.ChangingPin(PINCode);
            username = obj.UsernameSetChangingPin(username, userset);
            Initialize();
        }
        public void Deposit()
        {
            //Deposit code objecting to delegate
            Console.WriteLine("Insert the amount you want to deposit");
            int deposit = Int32.Parse(Console.ReadLine());

            BalanceChange bc1 = new BalanceChange(MakeADeposit);
            bc1(deposit);
            Console.WriteLine("This is your new balance " + bc1(deposit));
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
        public void Exit()
        {
            Console.WriteLine("Thank you for using snow bank");
        }
        public int MakeADeposit(int p)
        {

            int depostBalance = Balance() + p;

            return depostBalance;

        }

        // Continue & Check Method, Each Option need to have this until close the program
        public bool Check(string check)
        {

            if (check == "y")
            {
                PrincipalMenu();
                return true;

            }
            else
            {
                Console.WriteLine("------------------------THANKS FOR USING SNOW BANK---------------------");
                return false;

            }
        }



    }
}