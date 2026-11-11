using System;
using System.Collections.Generic;
using System.Text;

namespace GUIGradeCalculator
{
    public class GradeCalculator
    {
        //Calculate the average of student's entered grades

        public double CalculateAverage(List<int> grades)
        {
            if (grades.Count == 0)
            {
                return 0;
            }

            int gradeTotal = 0;

            foreach (int grade in grades)
            {
                gradeTotal += grade;
            }
            return (double) gradeTotal / grades.Count;
        }
//Determine the letter grade based on the average
public string DetermineLetter(double overallAverage)
        {
            string letterGrade;
            if (overallAverage >= 90)
            {
                letterGrade = "A";
            }
            else if (overallAverage >= 80)
            {
                letterGrade = "B";
            }
            else if (overallAverage >= 70)
            {
                letterGrade = "C";
            }
            else if (overallAverage >= 60)
            {
                letterGrade = "D";
            }
            else letterGrade = "F";
            return letterGrade;
        }
    }
}
