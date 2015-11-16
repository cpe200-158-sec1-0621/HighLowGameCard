using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGameCard
{
    class Player
    {
        private string _name;
        private Deck _dp;
        private int _point;
        private int _count;

        public Deck Dp
        {
            get { return _dp; }
            set { _dp = value; }
        }
        public int Point
        {
            get { return _point; }
            set { _point = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Player()
        {
            Dp = new Deck();
            Point = 0;
            Count = 0;
        }

        public void ShowScorePlayer(Player player)
        {
            Console.WriteLine(Name + " has " + Count + " Point ");
        }
    }
}
