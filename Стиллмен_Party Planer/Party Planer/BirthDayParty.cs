using System.Windows.Forms;

namespace Party_Planer
{
    class BirthDayParty:Party
    {
        public int CakeSize;

        public override int NumberOfPeople //инкапсуляция
        {
            get
            {
                return base.NumberOfPeople;
            }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        public BirthDayParty(int numberOfPeople, bool healthyDecorations, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, healthyDecorations, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        public string cakeWriting = "";
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength = 0;

                if (CakeSize == 8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Слишком много букв для" + CakeSize + "дюймового торта");
                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                    }
                    this.CakeWriting = cakeWriting;
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }

        public override decimal CalculateCost(bool q)
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;
            return TotalCost + CakeCost;
        }
    }
}
