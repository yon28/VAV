
namespace Party_Planer
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations;
        private bool healthyDecorations;
        public decimal CostOfDecorations =0;

        private int numberOfPeople;
        public virtual int NumberOfPeople //инкапсуляция
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                SetHealthyOption(healthyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = 15M * NumberOfPeople + 50M;
            }
            else
            {
                CostOfDecorations = 7.5M * NumberOfPeople + 30M;
            }
        }

        public Party(int numberOfPeople, bool healthyDecorations, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.healthyDecorations = healthyDecorations;
            this.fancyDecorations = fancyDecorations;
            CalculateCostOfDecorations(fancyDecorations);
        }

        public decimal CostOfBeveragesPerPerson;
        public decimal SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5M * NumberOfPeople;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M * NumberOfPeople;
            }
            return CostOfBeveragesPerPerson;
        }

        public virtual decimal CalculateCost(bool healthyOption)
        {
            decimal calculateCost = NumberOfPeople * CostOfFoodPerPerson + CostOfDecorations;

            if (healthyOption)
            {
                calculateCost *= 0.95M;
            }
            return calculateCost;
        }

    }
}
