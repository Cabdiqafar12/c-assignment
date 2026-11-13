Employee Salary Calculation and Qualification System (C#)

1. Project Overview

This project is developed using C# Windows Forms. It focuses on employee salary calculation and checking employee qualification based on salary and working experience.

The project contains two main parts:

1. Salary Calculation
2. Employee Qualification Checking

2. Salary Calculation

Description

The Salary Calculation section is used to calculate an employee's salary based on the information entered by the user.

Main Purpose

- Calculate employee salary.
- Display the calculated salary.
- Help the user understand salary information.

Explanation

The program receives employee information, performs the required calculations, and displays the result to the user.

3. Qualification Checking

Description

The Qualification Checking section determines whether an employee qualifies based on two conditions:

- Salary must be greater than 300.
- Working experience must be at least 2 years.

C# Code Explanation

First Condition:
"if (salary > 300)"

This checks whether the employee's salary is greater than 300.

Second Condition:
"if (years >= 2)"

This checks whether the employee has worked for at least two years.

MessageBox.Show("Qualify")

Displays a message when both conditions are true.

MessageBox.Show("Not Qualify")

Displays a message when one or both conditions are false.

4. Nested If Statement

The project uses a Nested If Statement. This means placing one "if" statement inside another "if" statement.

It helps the program check multiple conditions before displaying the final result.

5. Program Requirements

- C# Programming Language
- Visual Studio
- Windows Forms Application
- Basic knowledge of If, Else and Nested If statements.

6. Expected Output

Salary| Working Years| Result
500| 3| Qualify
400| 2| Qualify
250| 3| Not Qualify
500| 1| Not Qualify

7. Conclusion

This project helps students understand salary calculation, conditional statements, and Nested If statements in C#.

It also demonstrates how programming conditions can be used to make decisions based on employee salary and working experience.