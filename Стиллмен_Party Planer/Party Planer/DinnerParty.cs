
namespace Party_Planer
{
    public class DinnerParty: Party
    {
        

        public DinnerParty(int numberOfPeople, bool healthyDecorations, bool fancyDecorations): 
            base(numberOfPeople, healthyDecorations, fancyDecorations)
        {
            SetHealthyOption(healthyDecorations);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public override decimal CalculateCost(bool healthyOption)
        {
            decimal calculateCost = base.CalculateCost(healthyOption) + CostOfBeveragesPerPerson;

            if (healthyOption)
            {
                calculateCost *= 0.95M;
            }
            return calculateCost;
        }

    }
}
