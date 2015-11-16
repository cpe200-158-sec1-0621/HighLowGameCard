using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGameCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Player P1 = new Player();
            Player P2 = new Player();
            Control.SetUpCard();
            Console.Write("Player1's name : ");
            String nameP1 = Console.ReadLine();
            Console.Write("Player2's name : ");
            String nameP2 = Console.ReadLine();
            Control.SetUpPlayer(P1, P2, nameP1, nameP2);
            Control.PlayerDeck(P1, P2);

            int result = 0;
            int nextturn = 1;
            do
            {
                result = Control.CompareCard(P1, P2);
                P1.ShowScorePlayer(P1);
                P2.ShowScorePlayer(P2);
                if (P1.Dp.cards.Count == 0)
                    break;
                Console.WriteLine("Press any key and Enter to Continue...");
                String next = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            while (result != -1 && nextturn == 1);
            Control.EndGame(P1, P2);
            Console.ReadKey();
        }
    }
}
