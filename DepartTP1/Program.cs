using System;
using System.Collections.Generic;

namespace DepartTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BingoCard> bingoCards = new List<BingoCard>();
            int nbDraws = 0;

            for(int i = 0;i< 5; i++) {
                bingoCards.Add(new BingoCard(5, new NumberGenerator((long)i)));
                Console.WriteLine($"Carte {i+1}");
                Console.WriteLine("-----------");
                Console.WriteLine(bingoCards[i]);
            }

            NumberGenerator ballz = new NumberGenerator(8473718268);
            int winner = -1;
            do {
                int drawedNumber = ballz.Next();
                nbDraws++;
                int maxScore = 0;
                for(int i = 0; i < 5; i++) {
                    bingoCards[i].MarkNumber(drawedNumber);
                    int score = bingoCards[i].ComputeScore();
                    
                    if (score > maxScore) {
                        winner = i;
                    }
                }
            } while (winner == -1);

            Console.WriteLine($"La carte gagnante est la : {winner+1}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(bingoCards[winner]);
            Console.WriteLine($"Nombre de tirages : {nbDraws}");
            Console.WriteLine($"Pointage : {bingoCards[winner].ComputeScore()}");
            Console.ReadLine();
        }
    }
}
