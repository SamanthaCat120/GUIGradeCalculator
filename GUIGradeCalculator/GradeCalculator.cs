using System;
using System.Collections.Generic;
using System.Text;

namespace GUIGradeCalculator
{
    public class GradeCalculator
    {
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
