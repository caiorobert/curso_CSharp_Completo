namespace Course.Entities
{
    abstract class Account // essa palavra determina que essa é uma classe de herança total, não sendo possível instânciar essa classe
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //A palavra Virtual serve para esplicitar que este método pode ser sobreposto ou sobrescrito nas subclasses
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
