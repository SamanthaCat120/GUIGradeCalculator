using System;
using System.Collections.Generic;
using System.Text;

namespace GUIGradeCalculator
{
    public class StandardStudent : Student
    {
        //Constructor
        public StandardStudent(string studentName) : base(studentName)
        {
        }
        //Override the GetStudentStatus method to return "Standard Student"
        public override string GetStudentStatus()
        {
            return "Standard Student";
        }
    }
}

