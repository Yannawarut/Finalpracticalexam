# Finalpracticalexam
นายญาณวรุฒม์ บัวอินทร์ 683450054-3
Class Program {
    + Main(args: string[]) : void
    - AddSubject(course: List<Subject>) : void
    - AddStudent(course: List<Subject>) : void
    - ShowStudents(course: List<Subject>) : void
    - ShowStatistics(course: List<Subject>) : void
}

Class Subject {
    + SubjectCode : string
    + SubjectName : string
    + Students : List<Student>

    + Subject()
    + Subject(code: string, name: string)
    + RegisterUser(code: string, name: string) : void
}

Class Student {
    + StudentID : string
    + FullName : string
    + Score : double
    + Grade : string

    + Student(id: string, name: string, score: double)
    - CalculateGrade(score: double) : string
}

Program ..> Subject
Program ..> Student
Subject "1" o-- "0..*" Student
