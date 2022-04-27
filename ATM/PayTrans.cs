namespace ATM
{
    interface PaymentTransaction
    {
        //interface for payment
        int Payment(int balance, int amount);

    }
    //abstract class use
    public class PayTrans : PaymentTransaction
    {
        // virtual use for payment
        
        public virtual int Payment(int balance, int amount)
        {
            //object for Transaction
            Transaction eq = new Transaction();
            // check for the balance if not is enough balance
            if (balance < amount)
            {
                Console.WriteLine("Not enough balance");
                return balance;
            }
            else
            {
                // balance if the balance is enough
                balance = balance - amount;
                Console.WriteLine("--------------Processing-----------");
                Console.WriteLine("Transfer " + amount + " to the account");
                Console.WriteLine("Your new balance is " + balance);
                return balance;
            }
        }

    }
    // Paytrans inheritance
    public class Transaction : PayTrans
    {

        // Routing Number return class
        public int RoutingNumber(int routing)
        {
            return routing;

        }
        // Account Number return class
        public int AccountNumber(int account)
        {
            return account;

        }
        // Override Payment Class inheritance from PayTrans
        public override int Payment(int balance, int amount)
        {
            return base.Payment(balance, amount);

        }

    }

}