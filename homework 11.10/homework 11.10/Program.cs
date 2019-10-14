using System;
using System.Collections.Generic;
using System.Text;

namespace homework_11._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Tolchok();
            Console.WriteLine("Hello, stranger. What's your name?");
            human.Name = Console.ReadLine();
            Console.Write("Enter your date of birth (e.g. mm dd yyyy): ");
            human.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Welcome!!! Guys, we have a new Tolchok! {human.Name} is {human.Age} years old.");
            var Brigada = new Club();
            Brigada.Name = "Brigada";
            Brigada.Head = "Dexter";
            Brigada.Members = new List<Tolchok>();
            Brigada.Members.Add(new Tolchok() { Name = "Tinky-Vinky", DateOfBirth = new DateTime(1994, 6, 7) });
            Brigada.Members.Add(new Tolchok() { Name = "Dipsy", DateOfBirth = new DateTime(1995, 3, 6) });
            Brigada.Members.Add(new Tolchok() { Name = "Lala", DateOfBirth = new DateTime(1995, 4, 5) });
            Brigada.Members.Add(new Tolchok() { Name = "Po", DateOfBirth = new DateTime(1997, 11, 23) });
            Console.WriteLine($"Join us in our club named {Brigada.Name} ! Our head is {Brigada.Head}! These wonderful people are members of our club:");
            foreach (Tolchok member in Brigada.Members)
            {

                Console.WriteLine($"{ member.Name}, {member.Age} years old");
            }
            Console.WriteLine($"Come on, {human.Name}, let's play BlackJack!");
            BlackJack();

        }
        static void BlackJack()
        {

            int[] Deck = { 6, 7, 8, 9, 10, 2, 3, 4, 11 };
            Console.WriteLine("You have to score 21 points.I’ll give you one card first.");
            Random rnd = new Random();
            int player1 = Deck[rnd.Next(0, Deck.Length)];
            int player2 = Deck[rnd.Next(0, Deck.Length)];
            while (true)
            {

                Console.WriteLine($"Your card is {player1}. If you need more cards, enter 'hit'.If you don't, enter 'stop'.If you scored more than 21 points - enter 'surrender'.");
                string answerOfPlayer = Console.ReadLine();

                while (player2 < 21) player2 += Deck[rnd.Next(0, Deck.Length)];
                   
                if (answerOfPlayer == "hit")
                {
                    player1 += Deck[rnd.Next(0, Deck.Length)];
                    Console.WriteLine(player1);
                }
                else if (answerOfPlayer == "stop")
                {
                    if (player1 < player2)
                    {
                        Console.WriteLine($"You won! You scored {player1} points. I scored {player2} points.");
                        break;
                    }
                    else if (player1 > player2)
                    {
                        Console.WriteLine($"You lost! You scored {player1} points. I scored {player2} points.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We scored an equal amount of points.Draw!");
                        break;
                    }
                }
                else if (answerOfPlayer == "surrender")
                {
                    Console.WriteLine($"You lost.You scored {player1} points. I scored {player2} points.");
                    break;
                }
                else Console.WriteLine("I don't understand you. Enter 'hit', 'stop' or 'surrender.'");
            }
            Console.WriteLine("Good game!");
        }

    }
}
