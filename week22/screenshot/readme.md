 ### TOPICS OF THE CHAPTER

 Reading Input with TextBox Controls
 A First Look at Variables
 Numeric Data Type and Variables
 Performing Calculations
 Inputting and Outputting Numeric Values
 Formatting Numbers with the ToString Method
 Simple Exception Handling
 Using Named Constants
 Declaring Variables as Fields
 Using the Math Class
 More G U I Details
 Using the Debugger to Locate Logic Errors

 ### 1. TextBox

A **TextBox** is a control used in a Windows Form application to allow the user to **enter, edit, and display text or information**. It is commonly used to collect information from the user.

For example, in a student registration form, TextBoxes can be used for:

* **Student Name:** The user enters their name.
  *Example: Ahmed Ali*

* **Student ID:** The user enters their identification number.
  *Example: ST2026001*

* **Department:** The user enters their department.
  *Example: Computer Science*

* **Semester:** The user enters their semester.
  *Example: Semester 2*

After entering the information, the user can click the **Submit** button to display the information in the Output section.

**Example:**

```text
Student Name:  Ahmed Ali
Student ID:    ST2026001
Department:    Computer Science
Semester:      Semester 2
```

The TextBox makes it easy for the program to receive information from the user and store it in variables.


### Variable Names

Variables store data in a program.

**Examples:** `studentName`, `studentID`, `department`, `semester`.

### Primitive and Non-Primitive Data Types

Primitive: Basic data types that store a single value.
Examples: Integer, String, Boolean, Double.

Non-Primitive: Data types that can store multiple values or complex data.
Examples: Array, Class, Object.

### String concatenation 

means joining two or more strings together.

Example:

Dim fullName As String = firstName & " " & lastName

Result: Ahmed Ali



### Declare Multiple Variables

You can declare many variables in one statement.

Example:

Dim name, department, semester As String

### Assignment Compatibility for int Variables

Assignment compatibility means assigning a value to an int variable that has a compatible data type.

Example:

Dim x As Integer = 10


 ### Assignment Compatibility for double Variables

It means assigning a decimal value to a double variable.

Example:

Dim price As Double = 25.5


### Assignment Compatibility for decimal Variables

It means assigning a decimal value to a decimal variable.

Example:

Dim price As Decimal = 25.50D


### Explicit Conversion with Cast Operators

It means converting one data type to another using a cast operator.

Example:

Dim x As Double = 10.5
Dim y As Integer = CInt(x)


Integer Division

Integer division gives only the whole number part of a division.

Example:

Dim result As Integer = 10 \ 3

Result: 3

### Inputting and Outputting Numeric Values

It means entering numbers and displaying the result.

Example:

Dim num As Integer = CInt(txtNumber.Text)
lblResult.Text = num.ToString()

### Using the Math Class

The Math class is used to perform mathematical calculations.

Example:

Dim result As Double = Math.Sqrt(25)