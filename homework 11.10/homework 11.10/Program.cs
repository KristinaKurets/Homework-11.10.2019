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
            Console.Write("Enter your date of birth (e.g. 10/22/1987): ");
            human.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"So, tolchok {human.Name} is {human.Age} years old");
            var NameOf = new Clubs();
            NameOf.Head = "Dexter";
            NameOf.Club = "Brigada";
            Console.WriteLine($"Join us in our club named {NameOf.Club} ! Our head is {NameOf.Head}!");
            //foreach (MembersOfBrigada Members in (MembersOfBrigada[])Enum.GetValues(typeof(MembersOfBrigada)))
            //{
            //    Console.WriteLine($"{(int)Members} - {Members}");
            //}
        }
    }
}
