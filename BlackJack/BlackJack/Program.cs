using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating deck
            var deck = new List<Card>();
            foreach (CardSuits SuitName in Enum.GetValues(typeof(CardSuits)))
            {
                foreach (CardValues CardValue in Enum.GetValues(typeof(CardValues)))
                {
                    deck.Add(new Card { Suit = SuitName, Value = CardValue });
                }
            }
            //Shuffle deck:
            deck = deck.OrderBy(c => Guid.NewGuid()).ToList();
            
            //Game:
            Card player1 = deck.ElementAt(0);
            Console.WriteLine($"Your card is {player1}");
            Card player2 = deck.ElementAt(1);
        //    while (true)
        //    {

        //        Console.WriteLine($"Your card is {player1}. If you need more cards, enter 'hit'.If you don't, enter 'stop'.If you scored more than 21 points - enter 'surrender'.");
        //        string answerOfPlayer = Console.ReadLine();

        //        while (player2 < 21) player2 += Deck[rnd.Next(0, Deck.Length)];

        //        if (answerOfPlayer == "hit")
        //        {
        //            player1 += Deck[rnd.Next(0, Deck.Length)];
        //            Console.WriteLine(player1);
        //        }
        //        else if (answerOfPlayer == "stop")
        //        {
        //            if (player1 < player2)
        //            {
        //                Console.WriteLine($"You won! You scored {player1} points. I scored {player2} points.");
        //                break;
        //            }
        //            else if (player1 > player2)
        //            {
        //                Console.WriteLine($"You lost! You scored {player1} points. I scored {player2} points.");
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("We scored an equal amount of points.Draw!");
        //                break;
        //            }
        //        }
        //        else if (answerOfPlayer == "surrender")
        //        {
        //            Console.WriteLine($"You lost.You scored {player1} points. I scored {player2} points.");
        //            break;
        //        }
        //        else Console.WriteLine("I don't understand you. Enter 'hit', 'stop' or 'surrender.'");
        //    }
        //    Console.WriteLine("Good game!");
        //}

        




    }
}
