using Dara1223;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dara1223
{
    public class Pack
    {
        private readonly Statistics _statistics;
        private List<Card> Cards { get; }

        public Pack(Statistics statistics)
        {
            _statistics = statistics;
            Cards = new List<Card>();
            for (int value = 1; value <= 13; value++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    Cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            var rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }

        public void DealCards(int count)
        {
            Shuffle();
            var cards = Cards.GetRange(0, count);

            if (count == 3)
            {
                Handle3Cards(cards);
            }
            else if (count == 5)
            {
                Handle5Cards(cards);
            }
            else
            {
                Console.WriteLine("Invalid number of cards.");
            }
        }

        private void Handle3Cards(List<Card> cards)
        {
            var num1 = cards[0].GetNumber();
            var operator1 = cards[1].GetOperator();
            var num2 = cards[2].GetNumber();
            var expression = $"{num1} {operator1} {num2}";
            double answer = CalculateExpression(expression);

            Console.WriteLine($"Expression: {expression}");
            double userAnswer = Convert.ToDouble(Console.ReadLine());

            if (Math.Abs(userAnswer - answer) < 0.0001)
            {
                Console.WriteLine("Correct!");
                _statistics.RegisterCorrectAnswer();
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is {answer}.");
                _statistics.RegisterIncorrectAnswer();
            }
        }

        private void Handle5Cards(List<Card> cards)
        {
            var num1 = cards[0].GetNumber();
            var operator1 = cards[1].GetOperator();
            var num2 = cards[2].GetNumber();
            var operator2 = cards[3].GetOperator();
            var num3 = cards[4].GetNumber();
            var expression = $"{num1} {operator1} {num2} {operator2} {num3}";
            double answer = CalculateExpression(expression);

            Console.WriteLine($"Expression: {expression}");
            double userAnswer = Convert.ToDouble(Console.ReadLine());

            if (Math.Abs(userAnswer - answer) < 0.0001)
            {
                Console.WriteLine("Correct!");
                _statistics.RegisterCorrectAnswer();
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is {answer}.");
                _statistics.RegisterIncorrectAnswer();
            }
        }

        public double CalculateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);
            return result;
        }
    }
}