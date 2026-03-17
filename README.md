# Finalpracticalexam
นายญาณวรุฒม์ บัวอินทร์ 683450054-3

classDiagram
    class Program {
        static void Main(string[] args)
        +void AddSubject(List~Subject~ course)
        +void AddStudent(List~Subject~ course)
        +void ShowStudents(List~Subject~ course)
        +void ShowStatistics(List~Subject~ course)
    }
    class Subject {
        string SubjectCode
        string SubjectName
        List~Student~ Students
        +Subject()
        +Subject(string code, string name)
        +void RegisterUser(string subjectCode, string subjectName)
    }
    class Student {
        string StudentID
        string FullName
        double Score
        string Grade
        +Student(string id, string name, double score)
        -string CalculateGrade(double score)
    }
    Program --> Subject
    Program --> Student
    Subject --> Student
