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

        public override void Withdraw(double amount) //A palavra override serve para indicar que estou sobrescrevendo ou sobrepor um método da SuperClasse
        {
            base.Withdraw(amount); //Deixando assim, estou só chamando o método da SuperClasse
            //Balance -= amount; //Agora eu reescrevi as regras do meu método. Aqui eu não desconto a taxa
            Balance -= 2.0; //Desse jeito, eu usei a base para descontas a taxa dos 5, mais um desconto de 2 sendo a taxa desse método
        }
    }
}
