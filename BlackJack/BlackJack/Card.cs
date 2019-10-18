using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        
        public CardValues Value { get; set; }
        public CardSuits Suit { get; set; }
        public override string ToString()
        {
            return $"{Suit}:{Value}";
        }
        

    }
}
