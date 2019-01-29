using System;
using System.Collections.Generic;

namespace Entities
{
    class Player//376,382
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + "has just joined the game" + Environment.NewLine;
        }

        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));

            return randomCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + "has" + cardsIHave.Count + Card.Plural(value) + Environment.NewLine;
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values randomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, randomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            //textBoxOnForm.Text+=Name+"asks if anyone has a" +value+Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                //textBoxOnForm.Text+=Name+"mustdrawfromthestock."+ Environment.NewLine;
                cards.Add(stock.Deal());

            }
        }
    }
}