using System;
using System.Collections.Generic;
using System.Text;

namespace _01_StudentList
{
    public class Student
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private float _score1;
        public float Score1
        {
            get => _score1;
            set
            {
                if (value <= 0)
                    _score1 = 0;

                else if (value > 0 && value < 10)
                    _score1 = value;

                else
                    _score1 = 10;
            }
        }

        private float _score2;
        public float Score2
        {
            get => _score2;
            set
            {
                if (value <= 0)
                    _score2 = 0;

                else if (value > 0 && value < 10)
                    _score2 = value;

                else
                    _score2 = 10;
            }
        }

        public Student() { }
        public Student(string name)
        {
            Name = name;
            Score1 = 0;
            Score2 = 0;
        }

        public float CalculateAverageScore()
        {
            float average = (Score1 + Score2) / 2;
            CheckStatus(average);

            return average;
        }

        private void CheckStatus(float average)
        {
            if (average >= 5)
                Console.WriteLine($"Congratulations! Student {Name} succeeded with an average of {average}.");

            else
                Console.WriteLine($"Student {Name} failed with an average of {average}. Try again next time.");
        }
    }
}
