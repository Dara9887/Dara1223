using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dara1223
{
    public class Statistics
    {
        public int GamesPlayed { get; private set; }
        public int CorrectAnswers { get; private set; }
        public int IncorrectAnswers { get; private set; }

        public void RegisterCorrectAnswer()
        {
            GamesPlayed++;
            CorrectAnswers++;
        }

        public void RegisterIncorrectAnswer()
        {
            GamesPlayed++;
            IncorrectAnswers++;
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                using StreamWriter file = new StreamWriter(filePath);
                file.WriteLine($"Games Played: {GamesPlayed}");
                file.WriteLine($"Correct Answers: {CorrectAnswers}");
                file.WriteLine($"Incorrect Answers: {IncorrectAnswers}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving statistics to file: {ex.Message}");
            }
        }
    }

}
