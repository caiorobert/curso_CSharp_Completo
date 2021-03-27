namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            //double tax = 0.15;

            //if (AnualIncome >= 20000.00)
            //{
            //    tax = 0.25;
            //}

            //if (HealthExpenditures > 0)
            //{
            //    return (AnualIncome * tax) - (HealthExpenditures * 0.5);
            //}
            //else
            //{
            //    return (AnualIncome * tax) - HealthExpenditures;
            //}
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
