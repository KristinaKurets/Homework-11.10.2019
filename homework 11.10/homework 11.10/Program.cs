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
            Brigada.Members.Add(new Tolchok() { Name = "Po", DateOfBirth = new DateTime(1997, 11, 23)});
            Console.WriteLine($"Join us in our club named {Brigada.Name} ! Our head is {Brigada.Head}! These wonderful people are members of our club:");
            foreach (Tolchok member in Brigada.Members)
            {

                Console.WriteLine($"{ member.Name}, {member.Age} years old");
            }
        }
    }
}
