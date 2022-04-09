namespace ATM
{
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
            //Transaction part
            //Creating the object with Transaction in the class paytrans
            Transaction e = new Transaction();
            //Insert the data of the account you want to transfer
            //Insert routing number
            Console.WriteLine("Insert the routing number");
            int routing = Int32.Parse(Console.ReadLine());
            e.RoutingNumber(routing);
            //Insert account number
            Console.WriteLine("Insert the account number");
            int account = Int32.Parse(Console.ReadLine());
            e.AccountNumber(account);
            //predefined balance
            int balance = 800;
            //The amount to transfer
            Console.WriteLine("Insert the amount you want to transfer");
            int amount = Int32.Parse(Console.ReadLine());
            //object to payment refering to the abstract class 
            e.Payment(balance, amount);
        }
        public void SetMyFavouriteWithdrawal()
        {

        }
        public void ChangePIN()
        {
            Class1 cs = new Class1 ();
            cs.ChangingPin();
        }
        public void Deposit()
        {
            //Deposit code objecting to delegate

            BalanceChange bc1 = new BalanceChange(MakeADeposit);
            Console.WriteLine("Insert the amount you want to deposit");
            int deposit = Int32.Parse(Console.ReadLine());
            bc1(deposit);
            Console.WriteLine("This is your new balance " + bc1(deposit));


        }
        public static int MakeADeposit(int p)
        {
            int balance = 800;
            balance = balance + p;
            return balance;
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


}