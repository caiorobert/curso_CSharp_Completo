namespace Course.Entities
{
    class SavingsAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccounts()
        {

        }

        public SavingsAccounts(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
