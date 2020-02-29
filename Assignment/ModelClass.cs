using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ModelClass
    {
        public class Student
        {
            private int _Id;
            public int Id
            {
             set { _Id = value;      }
             get { return _Id; }
            }
            private string _studentname;

            public string StudentName

            { set  { _studentname = value ; }
                get{return _studentname ; }
            }

            
        }
        public class Course
        {
            private int _CourseId;
            public int CourseId
            {
                set { _CourseId = value; }
                get { return _CourseId; }
            }
            private string _CourseName;

            public string CourseName

            {
                set { _CourseName = value; }
                get { return _CourseName; }
            }

        }

        public class Professors
        {
            private int _CourseId;
            public int CourseId
            {
                set { _CourseId = value; }
                get { return _CourseId; }
            }
            private string _ProfessorName;

            public string ProfessorName

            {
                set { _ProfessorName = value; }
                get { return _ProfessorName; }
            }


        }

        public class StudentEnrollment
        {
            private int _StudentId;
            public int StudentId
            {
                set { _StudentId = value; }
                get { return _StudentId; }
            }
            private int _CourseId;

            public int CourseId

            {
                set { _CourseId = value; }
                get { return _CourseId; }
            }


        }

        public class WholeDetails
        {
            private string _StudentName;

            public string StudentName
            {
                set { _StudentName = value; }
                get { return _StudentName; }
            }

            private string _CourseName;

            public string CourseName
            {
                set { _CourseName = value; }

                get { return _CourseName; }
            }

            private string _professor;
            public string Professor
            {
                set { _professor = value; }
                get { return _professor; }
            }

        }

        public class ChangeData
        {
            private string _studentname;
            private string _actiontype;
            private string _actiontable;
            private string _professor;

            public string Professor
            {
                set { _professor = value; }
                get { return _professor; }
            }

            public string ActionTable
            {
                set { _actiontable = value; }
                get { return _actiontable; }
            }

            public string ActionType
            {
                set { _actiontype = value; }
                get { return _actiontype; }
            }

            public string StudentName
            {
                set { _studentname = value; }
                get { return _studentname; }
            }

        }
    }
}
