using Dara1223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dara1223
{
    public static class Tutorial
    {
        public static void ShowInstructions()
        {
            Console.WriteLine("MathsTutor Instructions:");
            Console.WriteLine("1. Choose the number of cards to deal (3 or 5).");
            Console.WriteLine("2. The cards will have a number (1-13) and an operator (+, -, *, /) based on their value and suit.");
            Console.WriteLine("3. For a 3-card deal, you'll receive two numbers and one sign.");
            Console.WriteLine("4. For a 5-card deal, you'll receive three numbers and two signs.");
            Console.WriteLine("5. Solve the math problem using the dealt cards.");
            Console.WriteLine("6. In a 5-card deal, apply the BODMAS rule to solve the problem.");
            Console.WriteLine("7. Enter your answer, and the application will tell you if it's correct or not.");
        }
    }
}