using System;
using System.Collections.Generic;
using System.IO;

namespace Entities
{
    public class Deck //364,366
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()//полная колода  //420! 427!
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)

                { cards.Add(new Card((Suits)suit, (Values)value)); }
            }
        }

        public Deck(IEnumerable<Card> initialCards)//загружает массив карт в колоду
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get => cards.Count;
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)//раздача
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);//удаляет карту из колоды
            return CardToDeal;//и возвращает ссылку на нее
        }

        public void Shuffle()//тасует карты
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        public IEnumerable<string> GetCardNames()// взвращает массив карт
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }

        public Card Peek(int cardNumber)//375
        {
            return cards[cardNumber];
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

        public void WriteCards(string filename)//419
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    writer.WriteLine(cards[i].Name);

                }
            }
        }
    }
}
