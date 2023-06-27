using System;
using System.Collections.Generic;

namespace DepartTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BingoCard> bingoCards = new List<BingoCard>();

            for(int i = 0;i< 5; i++) {
                bingoCards.Add(new BingoCard(5, new NumberGenerator((long)i+1)));     
            }

            NumberGenerator ballz = new NumberGenerator(8473718269);
            int winner = -1;
            do {
                ballz.Next();
                for(int i = 0; i < 5; i++) {
                    if (bingoCards[])
                }
            } while (winner == -1);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
