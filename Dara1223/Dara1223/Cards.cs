using Dara1223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dara1223
{
    class Card
    {
        public int Value { get; }
        public int Suit { get; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public int GetNumber() => Value;

        public string GetOperator()
        {
            return Suit switch
            {
                1 => "+",
                2 => "-",
                3 => "*",
                4 => "/",
                _ => throw new ArgumentException("Invalid suit"),
            };
        }
    }
}
