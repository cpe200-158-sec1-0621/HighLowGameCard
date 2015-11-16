using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGameCard
{
    class Control
    {
        static Deck mainDeck;

        public static void SetUpCard()
        {
            mainDeck = new Deck(13, 4);
            mainDeck.Shuffle();
        }

        public static void SetUpPlayer(Player P1, Player P2, string nameP1, string nameP2)
        {
            P1.Name = nameP1;
            P2.Name = nameP2;
        }
        public static void PlayerDeck(Player P1, Player P2)
        {
            for (int i = 0; i < 52; i +=2)
            {
                P1.Dp.cards.Add(mainDeck.cards[i]);
                P2.Dp.cards.Add(mainDeck.cards[i + 1]);
            }
        }

        public static void PlayerWinTurn(Player P, int NumberCard = 1)
        {
            P.Count += (NumberCard) * 2;
        }

        public static void RemoveCard(Player P1, Player P2, int Lenght)
        {
            int LastCard = P1.Dp.cards.Count - 1;
            P1.Dp.cards.RemoveRange(LastCard - Lenght + 1, Lenght);
            P2.Dp.cards.RemoveRange(LastCard - Lenght + 1, Lenght);
        }

        public static void DrawTurn(Player P1, Player P2)
        {
            Console.WriteLine(" <Draw> : Reshffle Deck !!!!");
            P1.Dp.Shuffle();
            if (P1.Dp.cards.Count != 2)
            {
                P2.Dp.Shuffle();
            }
        }

        public static int CompareCard(Player P1, Player P2)
        {
            int _value = 0;
            int LastCard = P1.Dp.cards.Count - 1;
            int P1LastCard = P1.Dp.cards[LastCard].Face;
            int P2LastCard = P2.Dp.cards[LastCard].Face;
            Console.WriteLine(P1.Name + " get " + P1.Dp.cards[LastCard]);
            Console.WriteLine(P2.Name + " get " + P2.Dp.cards[LastCard]);
            if (P1.Dp.cards.Count < P1LastCard && P1LastCard == P2LastCard)
            {
                Console.WriteLine(" <Draw> : don't have card to continue playing ");
                _value =  -1;
            }
            else if (P1LastCard == P2LastCard)
            {
                int LastCardDraw = P1LastCard;
                Console.WriteLine(" <Draw> : Draw " + LastCardDraw + " Card ");
                Console.WriteLine(P1.Name + " get " + P1.Dp.cards[LastCardDraw]);
                Console.WriteLine(P2.Name + " get " + P2.Dp.cards[LastCardDraw]);
                int P1BeforeLast = P1.Dp.cards[LastCardDraw].Face;
                int P2BeforeLast = P2.Dp.cards[LastCardDraw].Face;
                if (P1BeforeLast < P2BeforeLast)
                {
                    PlayerWinTurn(P1, LastCardDraw + 1);
                    RemoveCard(P1, P2, LastCardDraw + 1);
                    Console.WriteLine(" Player1 Win!!!!!!!! ");
                    _value = 1;
                }
                else if (P1BeforeLast > P2BeforeLast)
                {
                    PlayerWinTurn(P2, LastCardDraw + 1);
                    RemoveCard(P1, P2, LastCardDraw + 1);
                    Console.WriteLine(" Player2 Win!!!!!!!! ");
                    _value = 2;
                }
                else
                {
                    DrawTurn(P1, P2);
                    _value = 0;
                }
            }
            else if (P1LastCard < P2LastCard)
            {
                PlayerWinTurn(P1);
                Console.WriteLine(" Player1 Win!!!!!!!! ");
                RemoveCard(P1, P2, 1);
                _value = 1;
            }
            else if (P1LastCard > P2LastCard)
            {
                PlayerWinTurn(P2);
                Console.WriteLine(" Player2 Win!!!!!!!! ");
                RemoveCard(P1, P2, 1);
                _value =  2;
            }
            return _value;
        }

        public static void EndGame(Player P1, Player P2)
        {
            Console.WriteLine(" || Finally " + (P1.Count > P2.Count ? P1.Name : P2.Name) + " is Winner ! ||");
        }

    }
}
