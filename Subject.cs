using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalpracticalexam
{
    internal class Subject
    {
        public string SubjectCode;
        public string SubjectName;
        public List<Student> Students = new List<Student>();

        public Subject()
        {
        }

        public Subject(string code, string name)
        {
            SubjectCode = code;
            SubjectName = name;

        }

        internal void RegisterUser(string subjectCode, string subjectName)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
        }
    }
}
