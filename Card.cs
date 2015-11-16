using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGameCard
{
    class Card
    {
        private int _face;
        private int _suit;
        public int Face
        {
            get { return _face; }
            set { _face = value ; }
        }
        public int Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        protected string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        protected string[] face = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        public override string ToString()
        {
            return face[Face - 1] + "(" + Face + ") " + suit[Suit - 1];
        }
      

       


    }
}
