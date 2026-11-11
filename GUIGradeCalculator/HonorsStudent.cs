using System;
using System.Collections.Generic;
using System.Text;

namespace GUIGradeCalculator
{
    public class HonorsStudent : Student
    {
        //Constructor
        public HonorsStudent(string studentName) : base(studentName)
        {
        }
        //Override the GetStudentStatus method to return "Honors Student"
        public override string GetStudentStatus()
        {
            return "Honors Student";
        }
    }
}
