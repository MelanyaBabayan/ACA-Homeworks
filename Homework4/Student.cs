using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public struct Student
    {
        public string Name;
        public int[] Scores;

        public Student(string name, int[] scores) 
        {
            Name = name;
            Scores = scores;
        }
        public double GetAverageScore()
        {
            if (Scores.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (var score in Scores)
            {
                sum += score;
            }
            return sum / Scores.Length;
        }  
        public static Student CreateStudentFromInput()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter scores separated by commas: ");
            string scoresInput = Console.ReadLine();

            string[] scoreStrings = scoresInput.Split(',');
            int[] scores = Array.ConvertAll(scoreStrings, int.Parse);

            return new Student(name, scores);
        }
        public int GetScoresRoundedAverage()
        {
            return (int)Math.Round(GetAverageScore());
        }

        public override string ToString()
        {
            return $"{Name}: {GetAverageScore()} => {GetScoresRoundedAverage()}.";
        }

    }
}
