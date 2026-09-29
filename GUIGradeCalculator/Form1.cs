namespace GUIGradeCalculator
{
    public partial class Form1 : Form
    {
        //variables
        List<int> myGrades = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddGradeBtn_Click(object sender, EventArgs e)
        {
            int grade;

            //validate grade entry

            if (int.TryParse(TxtBxGrade.Text, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    //add grade

                    myGrades.Add(grade);

                    LstBxGrades.DataSource = null;
                    LstBxGrades.DataSource = myGrades;

                    LblStatus.Text = "";
                    TxtBxGrade.Clear();
                }

                //display status message

                else
                {
                    LblStatus.Text = "Enter a grade between 0 and 100.";
                }
            }
            else
            {
                LblStatus.Text = "Enter a numerical grade.";
            }
        }


        private void LstBxGrades_DoubleClick(object sender, EventArgs e)
        {
            //prevent program from crashing with empty box

            if (LstBxGrades.SelectedIndex < 0)
            {
                return;
            }

            //remove grade

            myGrades.RemoveAt(LstBxGrades.SelectedIndex);

            LstBxGrades.DataSource = null;
            LstBxGrades.DataSource = myGrades;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string studentName = TxtBxName.Text;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                LblStatus.Text = "Enter a student name.";
                return;
            }

            if(myGrades.Count == 0)
            {
                LblStatus.Text = "Enter at least one grade.";
                return;
            }

            double overallAverage;
            string letterGrade;


            //calculate average

            overallAverage = CalculateAverage(myGrades);


            //determine letter grade

            letterGrade = DetermineLetter(overallAverage);

            //display results

            DisplayResults(studentName, overallAverage, letterGrade);
            LblStatus.Text = "";

        }
        static double CalculateAverage(List<int> grades)
        {
            int gradeTotal = 0;

            foreach (int grade in grades)
            {
                gradeTotal += grade;
            }

            double overallAverage = (double)gradeTotal / grades.Count;
            return overallAverage;
        }
        static string DetermineLetter(double overallAverage)
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

        private void DisplayResults(string studentName, double overallAverage, string letterGrade)
        {
            DisplayResultsLbl.Text = "Student: " + studentName +
                                     "\nAverage: " + overallAverage.ToString("F2") +
                                     "\nLetter Grade: " + letterGrade;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtBxName.Clear();
            TxtBxGrade.Clear();

            myGrades.Clear();

            LstBxGrades.DataSource = null;

            LblStatus.Text = "";
            DisplayResultsLbl.Text = "";
        }
    }
}
