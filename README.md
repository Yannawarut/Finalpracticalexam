# Finalpracticalexam
นายญาณวรุฒม์ บัวอินทร์ 683450054-3
+----------------------+
|       Program        |
+----------------------+
| - Main(string[] args)|
| - AddSubject(course) |
| - AddStudent(course) |
| - ShowStudents(course)|
| - ShowStatistics(course)|
+----------------------+

            |
            | uses
            v

+----------------------+
|       Subject        |
+----------------------+
| + SubjectCode : string
| + SubjectName : string
| + Students : List<Student>
+----------------------+
| + Subject()          |
| + Subject(code,name) |
| + RegisterUser(code,name) |
+----------------------+

            |
            | 1 ---- * (Aggregation)
            v

+----------------------+
|       Student        |
+----------------------+
| + StudentID : string |
| + FullName : string  |
| + Score : double     |
| + Grade : string     |
+----------------------+
| + Student(id,name,score) |
| - CalculateGrade(score)  |
+----------------------+
