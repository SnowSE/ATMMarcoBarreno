namespace ATM
{
    //Delegate code
   delegate int BalanceChange(int balan);

    public class Deposit
    {
        static int balance = 800;
        
        public static int MakeADeposit (int p)
        {
            balance = balance + p;
            return balance;
        }
        public static int DepositReturn()
        {
            return balance;
        }
        
    }
}