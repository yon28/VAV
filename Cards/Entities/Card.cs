namespace Entities
{
    public class Card //338 
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get => Value.ToString() + " of " + Suit.ToString();
        }
        public override string ToString()//360
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit) //363
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string M()//363
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            //  MessageBox.Show(
            return doesItMatch.ToString();
        }

        public static string Plural(Values value) //377
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }


    }
}
