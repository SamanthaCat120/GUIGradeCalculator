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
            if (index >= 0 && index < Grades.Count)
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

        //Calculate the average of the student's grades
        public double CalculateAverage()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            int gradeTotal = 0;
            foreach (int grade in Grades)
            {
                gradeTotal += grade;
            }
            return (double)gradeTotal / Grades.Count;
        }

        //Method that derived classes can override
        public virtual string GetStudentStatus()
        {
            return "Student";
        }
    }

}
