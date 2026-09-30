namespace GUIGradeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitle = new Label();
            LblName = new Label();
            TxtBxName = new TextBox();
            LblGrade = new Label();
            TxtBxGrade = new TextBox();
            LstBxGrades = new ListBox();
            AddGradeBtn = new Button();
            CalcBtn = new Button();
            LblResults = new Label();
            ExitBtn = new Button();
            LblRemoveInstructions = new Label();
            LblStatus = new Label();
            DisplayResultsLbl = new Label();
            ClearBtn = new Button();
            LblListBox = new Label();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitle.Location = new Point(183, 16);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(161, 25);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Grade Calculator";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(98, 61);
            LblName.Name = "LblName";
            LblName.Size = new Size(99, 15);
            LblName.TabIndex = 1;
            LblName.Text = "Enter Your Name:";
            // 
            // TxtBxName
            // 
            TxtBxName.Location = new Point(208, 53);
            TxtBxName.Name = "TxtBxName";
            TxtBxName.Size = new Size(100, 23);
            TxtBxName.TabIndex = 2;
            // 
            // LblGrade
            // 
            LblGrade.AutoSize = true;
            LblGrade.Location = new Point(98, 104);
            LblGrade.Name = "LblGrade";
            LblGrade.Size = new Size(76, 15);
            LblGrade.TabIndex = 3;
            LblGrade.Text = "Enter a grade";
            // 
            // TxtBxGrade
            // 
            TxtBxGrade.Location = new Point(208, 101);
            TxtBxGrade.Name = "TxtBxGrade";
            TxtBxGrade.Size = new Size(100, 23);
            TxtBxGrade.TabIndex = 4;
            // 
            // LstBxGrades
            // 
            LstBxGrades.FormattingEnabled = true;
            LstBxGrades.Location = new Point(118, 187);
            LstBxGrades.Name = "LstBxGrades";
            LstBxGrades.Size = new Size(180, 94);
            LstBxGrades.TabIndex = 6;
            LstBxGrades.DoubleClick += LstBxGrades_DoubleClick;
            // 
            // AddGradeBtn
            // 
            AddGradeBtn.Location = new Point(347, 104);
            AddGradeBtn.Name = "AddGradeBtn";
            AddGradeBtn.Size = new Size(75, 23);
            AddGradeBtn.TabIndex = 5;
            AddGradeBtn.Text = "Add Grade";
            AddGradeBtn.UseVisualStyleBackColor = true;
            AddGradeBtn.Click += AddGradeBtn_Click;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(118, 296);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(113, 23);
            CalcBtn.TabIndex = 7;
            CalcBtn.Text = "Calculate Grade";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // LblResults
            // 
            LblResults.AutoSize = true;
            LblResults.Location = new Point(137, 343);
            LblResults.Name = "LblResults";
            LblResults.Size = new Size(47, 15);
            LblResults.TabIndex = 9;
            LblResults.Text = "Results:";
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(457, 18);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 14;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // LblRemoveInstructions
            // 
            LblRemoveInstructions.AutoSize = true;
            LblRemoveInstructions.Location = new Point(304, 205);
            LblRemoveInstructions.Name = "LblRemoveInstructions";
            LblRemoveInstructions.Size = new Size(295, 15);
            LblRemoveInstructions.TabIndex = 11;
            LblRemoveInstructions.Text = "<- Double-click grade to remove if entered incorrectly.";
            // 
            // LblStatus
            // 
            LblStatus.ForeColor = Color.Crimson;
            LblStatus.Location = new Point(171, 136);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(251, 23);
            LblStatus.TabIndex = 12;
            // 
            // DisplayResultsLbl
            // 
            DisplayResultsLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DisplayResultsLbl.BackColor = Color.Tan;
            DisplayResultsLbl.Location = new Point(219, 343);
            DisplayResultsLbl.Name = "DisplayResultsLbl";
            DisplayResultsLbl.Size = new Size(134, 61);
            DisplayResultsLbl.TabIndex = 13;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(466, 53);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear Form";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // LblListBox
            // 
            LblListBox.AutoSize = true;
            LblListBox.Location = new Point(103, 159);
            LblListBox.Name = "LblListBox";
            LblListBox.Size = new Size(86, 15);
            LblListBox.TabIndex = 15;
            LblListBox.Text = "Entered Grades";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 422);
            Controls.Add(LblListBox);
            Controls.Add(ClearBtn);
            Controls.Add(DisplayResultsLbl);
            Controls.Add(LblStatus);
            Controls.Add(LblRemoveInstructions);
            Controls.Add(ExitBtn);
            Controls.Add(LblResults);
            Controls.Add(CalcBtn);
            Controls.Add(AddGradeBtn);
            Controls.Add(LstBxGrades);
            Controls.Add(TxtBxGrade);
            Controls.Add(LblGrade);
            Controls.Add(TxtBxName);
            Controls.Add(LblName);
            Controls.Add(LblTitle);
            MinimumSize = new Size(616, 461);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private Label LblName;
        private TextBox TxtBxName;
        private Label LblGrade;
        private TextBox TxtBxGrade;
        private ListBox LstBxGrades;
        private Button AddGradeBtn;
        private Button CalcBtn;
        private Label LblResults;
        private Button ExitBtn;
        private Label LblRemoveInstructions;
        private Label LblStatus;
        private Label DisplayResultsLbl;
        private Button ClearBtn;
        private Label LblListBox;
    }
}
