using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGameCard
{
    class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
        }
        public Deck(int face, int suit) : this()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card { Face = j+1, Suit = i+1 });
                }
            }
        }
        public void Shuffle()
        {
            Random ran = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                var j = ran.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        public void ViewCard()
        {
            foreach (Card Viewcard in this.cards)
                Console.WriteLine(Viewcard);
        }
    }
}
