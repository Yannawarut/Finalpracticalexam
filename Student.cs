using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalpracticalexam
{
    internal class Student
    {
        public string StudentID;
        public string FullName;
        public double Score;
        public string Grade;

        public Student(string id, string name, double score)
        {
            StudentID = id;
            FullName = name;
            Score = score;
            Grade = CalculateGrade(score);
        }

        private string CalculateGrade(double score)
        {
            if (score >= 80) return "A";
            else if (score >= 75) return "B+";
            else if (score >= 70) return "B";
            else if (score >= 65) return "C+";
            else if (score >= 60) return "C";
            else if (score >= 55) return "D+";
            else if (score >= 50) return "D";
            else return "F";
        }
    }
}
