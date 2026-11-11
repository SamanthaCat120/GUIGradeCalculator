using System;
using System.Collections.Generic;
using System.Text;

namespace GUIGradeCalculator
{
    public class Student
    {
        //Properties
        public string StudentName { get; set; }
        public List<int> Grades { get; set; }

        //Constructor
        public Student(string studentName)
        {
            StudentName = studentName;
            Grades = new List<int>();
        }

        //Add a grade to the student's list of grades
        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
        }

        //Remove  a grade by its position
        public void RemoveGrade(int index)
        {
            if (index >= 0 && index < Grades.Count)
            {
                Grades.RemoveAt(index);
            }
        }

        //Method that derived classes can override
        public virtual string GetStudentStatus()
        {
            return "Student";
        }
    }

}
