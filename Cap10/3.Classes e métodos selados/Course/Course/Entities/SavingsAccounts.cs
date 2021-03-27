namespace Course.Entities
{
    sealed class SavingsAccounts : Account //Selando a subclasse, para evitar que existam classes derivadas dela
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
        //Tb posso usar o sealed para selar métodos sobrepostos, evitando que eles sejam sobrepostos em outras SubClasses dessa classe
        public sealed override void Withdraw(double amount) //A palavra override serve para indicar que estou sobrescrevendo ou sobrepor um método da SuperClasse
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
