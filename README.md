# Student Grade Calculator 
A Windows Forms application that accepts grades, validates input, calculates an average, and determines a letter grade. This was first a console application that was converted to a Windows Forms application.

## How to Run

Open the solution in Visual Studio and run the application.

## How to Use

Enter the student's name, select whether student is in the Honors program or is a Standard student, and enter a grade from 0 to 100. Click Add Grade to add each grade to the list. Repeat for additional grades. Grades will appear in the ListBox. When through, click Calculate Grades. Grades can be removed by double-clicking on the desired grade in the ListBox. Clear Form resets the form, and Exit closes the application.

Note: Honors Student and Standard Student currently calculate grades the same way. The separate classes demonstrate polymorphism and allow for future enhancements, such as weighted grading.

## Class Structure and Object-Oriented Programming
The application uses four classes to separate student information, grade management, and calculations.

- **Student:** The base class that stores the student's name and grades and provides methods for adding and removing grades. It also defines the virtual GetStudentStatus() method.
- **StandardStudent:** Inherits from Student and overrides GetStudentStatus() to reutrn "Standard Student."
- **HonorsStudent:** Inherits from Student and overrides GetStudentStatus() to return "Honors Student."
- **GradeCalculator:** Contains methods for calculating the average and determining the letter grade.

The application demonstrates encapsulation by using properties and methods to manage student information, inheritence by allowing StandardStudent and HonorsStudent to reuse memberes of Student, and polymorphism by using the overridden GetStudentStatus() method to display the selected student type.

## Controls and Events

The application uses text boxes for entering the student's name and grades, a dropdown box to select Honors Student or Standard Student, a ListBox for displaying the entered grades, and buttons for adding grades, calculating results, clearing the form, and exiting the application.
Button Click events perform the main application actions. Double-clicking a grade in the ListBox removes a grade.

## Input Validation

The application validates grade entries to ensure they are numeric and within the range of 0 and 100. Invalid input displays a message and does not process the grade.

## Known Limitations

All entered grades are weighted equally. Since limit is 0 to 100, extra credit that is above 100 is not able to be processed.

## Application Screenshots

<img width="602" height="520" alt="HonorsStudent png" src="https://github.com/user-attachments/assets/d944e47f-189b-462d-9dcb-9a6ff02ae3a0" />
<br>
<br>
<img width="602" height="520" alt="StandardStudent png" src="https://github.com/user-attachments/assets/78a08dff-1868-4b77-8398-67d63d698856" />
<br>
<br>
<img width="602" height="520" alt="Error png" src="https://github.com/user-attachments/assets/e4b2f0c6-dad8-4c6b-bce6-1dc77207d81b" />



