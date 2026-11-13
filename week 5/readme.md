Employee Gross Pay Calculator – C# Windows Forms

1. Project Overview

This project is a C# Windows Forms application designed to calculate an employee's gross pay based on the number of hours worked and the employee's pay rate.

The application allows users to enter working hours and pay rate, calculate the gross salary, display the result, clear all input fields, and close the application.

2. Project Objectives

- To understand C# Windows Forms programming.
- To calculate employee gross pay.
- To use conditional statements (If and Else).
- To validate user input.
- To handle errors using Try and Catch.
- To use Clear and Close buttons.

3. Technologies Used

- Programming Language: C#
- Framework: .NET Windows Forms
- IDE: Visual Studio
- Controls: TextBox, Label, Button, MessageBox.

4. Main Program Features

A. Calculate Gross Pay

The Calculate button takes two inputs:

- Hours Worked
- Pay Rate

It checks whether the entered values are valid numbers. If the inputs are correct, the application calculates the employee's gross pay.

Formula:

Gross Pay = Hours Worked × Pay Rate

The calculated result is displayed in the gross pay label.

B. Input Validation and Else Statement

The program uses If and Else statements to check user input.

If the user enters valid numbers, the calculation continues.

If the user enters incorrect values, a MessageBox displays an error message asking the user to enter valid hours worked and pay rate.

This prevents incorrect input from being used in the calculation.

C. Clear Button

The Clear button removes all entered information from the application.

It uses:

- "txthours.Clear();" to clear working hours.
- "txtpay.Clear();" to clear the pay rate.
- "lblgross.Text = "";" to clear the gross pay result.

This allows users to enter new information without restarting the application.

D. Close Button

The Close button is used to exit the current Windows Form.

It uses:

"this.Close();"

When the user clicks the Close button, the current application form closes.

5. Error Handling

The application uses Try and Catch with input validation to prevent errors when users enter invalid information.

"TryParse()" checks whether the input can be converted into a numeric value.

The Catch block can handle unexpected errors and display an appropriate message to the user.

6. Conclusion

In conclusion, this project demonstrates how to develop a simple employee gross pay calculator using C# Windows Forms.

It combines mathematical calculations, conditional statements, input validation, error handling, and button events.

The project also improves understanding of how to design user-friendly desktop applications using C#.