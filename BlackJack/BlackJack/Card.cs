using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        
        public string Value { get; set; }
        public string Suit { get; set; }
        public override string ToString()
        {
            return $"{Suit}:{Value}";
        }
        

    }
}
