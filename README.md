# Student Grade Calculator 
A Windows Forms application that accepts grades, validates input, calculates an average, and determines a letter grade. This was first a console application that was converted to a Windows Forms application.

## How to Run

Open the solution in Visual Studio and run the application.

## How to Use

Enter the student's name and enter a grade from 0 to 100. Click Add Grade to add each grade to the list. Grades will appear in the ListBox. When through, click Calculate Grades. Grades can be removed by double-clicking on the desired grade in the ListBox. Clear Form clears the form, and Exit closes the application.

## Controls and Events

The application uses text boxes for entering the student's name and grades, a ListBox for displaying the entered grades, and buttons for adding grades, calculating results, clearing the form, and exiting the application.
Button Click events perform the main application actions. Double-clicking a grade in the ListBox removes a grade.

## Input Validation

The application validates grade entries to ensure they are numeric and within the range of 0 and 100. Invalid input displays a message and does not process the grade.

## Known Limitations

All entered grades are weighted equally. Since limit is 0 to 100, extra credit that is above 100 is not able to be processed.

## Application Screenshots

<img width="802" height="482" alt="image" src="https://github.com/user-attachments/assets/f7a06ec8-6201-4198-96c4-a7fb52f0055f" />
<br>
<br>
<img width="802" height="482" alt="image" src="https://github.com/user-attachments/assets/c0c80251-a327-4dc1-9120-c47df2fb3d75" />
<br>
<br>

