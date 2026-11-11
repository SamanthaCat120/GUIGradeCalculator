namespace GUIGradeCalculator
{
    public partial class Form1 : Form
    {
        //Student object
        private Student currentStudent = new StandardStudent("");
        private GradeCalculator gradeCalculator = new GradeCalculator();
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

                    currentStudent.AddGrade(grade);

                    LstBxGrades.DataSource = null;
                    LstBxGrades.DataSource = currentStudent.Grades;

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

            currentStudent.RemoveGrade(LstBxGrades.SelectedIndex);

            LstBxGrades.DataSource = null;
            LstBxGrades.DataSource = currentStudent.Grades;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string studentName = TxtBxName.Text;
            currentStudent.StudentName = studentName;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                LblStatus.Text = "Enter a student name.";
                return;
            }

            if(currentStudent.Grades.Count == 0)
            {
                LblStatus.Text = "Enter at least one grade.";
                return;
            }

            double overallAverage;
            string letterGrade;


            //calculate average

            overallAverage = currentStudent.CalculateAverage();


            //determine letter grade

            letterGrade = gradeCalculator.DetermineLetter(overallAverage);

            //display results

            DisplayResults(studentName, overallAverage, letterGrade, currentStudent.GetStudentStatus());
            LblStatus.Text = "";

        }
        

        private void DisplayResults(string studentName, double overallAverage, string letterGrade, string studentStatus)
        {
            DisplayResultsLbl.Text = "Student: " + studentName +
                                     "\nStatus: " + studentStatus +
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

            currentStudent.Grades.Clear();
            currentStudent.StudentName = "";

            LstBxGrades.DataSource = null;

            LblStatus.Text = "";
            DisplayResultsLbl.Text = "";
        }
    }
}
