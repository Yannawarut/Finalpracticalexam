using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalpracticalexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Subject> course = new List<Subject>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ระบบคำนวณเกรด =====");
                Console.WriteLine("1. เปิดรายวิชาใหม่");
                Console.WriteLine("2. เพิ่มนักศึกษา");
                Console.WriteLine("3. แสดงรายชื่อนักศึกษา");
                Console.WriteLine("4. แสดงสถิติรายวิชา");
                Console.WriteLine("5. ออกจากโปรแกรม");
                Console.Write("เลือกเมนู: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddSubject(course); break;
                    case "2": AddStudent(course); break;
                    case "3": ShowStudents(course); break;
                    case "4": ShowStatistics(course); break;
                    case "5": return;
                    default: Console.WriteLine("เลือกไม่ถูกต้อง"); break;
                }

                Console.WriteLine("\nกด Enter เพื่อดำเนินการต่อ...");
                Console.ReadLine();

            }
        }
        private static void ShowStatistics(List<Subject> course)
        {
            if (course.Count == 0)
            {
                Console.WriteLine("ยังไม่มีรายวิชา!");
                return;
            }

            Console.WriteLine("\n===== Statistics =====");

            foreach (var subject in course)
            {
                Console.WriteLine($"\nวิชา: {subject.SubjectCode} - {subject.SubjectName}");

                if (subject.Students.Count == 0)
                {
                    Console.WriteLine("ไม่มีข้อมูล");
                    continue;
                }

                double max = subject.Students.Max(s => s.Score);
                double min = subject.Students.Min(s => s.Score);
                double avg = subject.Students.Average(s => s.Score);

                Console.WriteLine($"Max: {max}");
                Console.WriteLine($"Min: {min}");
                Console.WriteLine($"Average: {avg:F2}");
            }
        }

        private static void ShowStudents(List<Subject> course)
        {
            if (course.Count == 0)
            {
                Console.WriteLine("ยังไม่มีรายวิชา!");
                return;
            }

            Console.WriteLine("\n===== Student List =====");

            foreach (var subject in course)
            {
                Console.WriteLine($"\nวิชา: {subject.SubjectCode} - {subject.SubjectName}");

                if (subject.Students.Count == 0)
                {
                    Console.WriteLine("ไม่มีนักศึกษา");
                    continue;
                }

                foreach (var s in subject.Students)
                {
                    Console.WriteLine($"{s.StudentID} | {s.FullName} | {s.Score} | {s.Grade}");
                }
            }
        }

        private static void AddStudent(List<Subject> course)
        {
            if (course.Count == 0)
            {
                Console.WriteLine("ยังไม่มีรายวิชา!");
                return;
            }

            Console.WriteLine("\n===== Add Student =====");

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {course[i].SubjectCode} - {course[i].SubjectName}");
            }

            Console.Write("เลือกวิชา: ");
            int choice = int.Parse(Console.ReadLine());

            Subject subject = course[choice - 1];

            Console.Write("Student ID: ");
            string id = Console.ReadLine();

            Console.Write("Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Score: ");
            double score = double.Parse(Console.ReadLine());

            Student student = new Student(id, name, score);
            subject.Students.Add(student);

            Console.WriteLine($"เพิ่มสำเร็จ! เกรด: {student.Grade}");
        }

        private static void AddSubject(List<Subject> course)
        {
            Console.WriteLine("\n===== Add Subject =====");

            Console.Write("Enter Subject Code: ");
            string subjectCode = Console.ReadLine();

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject();
            subject.RegisterUser(subjectCode, subjectName);

            course.Add(subject);

            Console.WriteLine("เพิ่มรายวิชาเรียบร้อย!");
        }
    }
}
