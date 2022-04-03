namespace ATM
{
    interface PaymentTransaction
    {
        int Payment(int balance, int amount);

    }
    public abstract class PayTrans : PaymentTransaction
    {


        public virtual int Payment(int balance, int amount)
        {
            Transaction eq = new Transaction();
            if (balance < amount)
            {
                Console.WriteLine("Not enough balance");
                return balance;
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("--------------Processing-----------");
                Console.WriteLine("Transfer" + amount + "to the account");
                Console.WriteLine("Your new balance is " + balance);
                return balance;
            }
        }

    }
    public class Transaction : PayTrans
    {


        public int RoutingNumber(int routing)
        {
            return routing;

        }
        public int AccountNumber(int account)
        {
            return account;

        }
        public override int Payment(int balance, int amount)
        {
            return base.Payment(balance, amount);

        }






    }

}