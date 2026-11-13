🏨 HOTEL BOOKING SYSTEM

C# Windows Forms Application

1. Introduction

The Hotel Booking System is a C# Windows Forms application designed to manage hotel reservations. It allows users to enter guest information, select room details, calculate booking costs, and display booking summaries.

2. Project Objectives

- To manage hotel guest information.
- To calculate room costs automatically.
- To calculate breakfast costs.
- To calculate the total booking price.
- To display booking details in a ListBox.

3. Main Features

Guest Information

- Guest Name
- Guest Age
- Room Type
- Number of Nights
- Number of Guests

Room Booking
The system calculates the room cost using the room rate and number of nights.

Breakfast Option
Guests can choose breakfast using a CheckBox. Breakfast costs $10 per guest per night.

Cost Calculation
The system calculates:

- Room Cost
- Breakfast Cost
- Total Cost

Booking Summary
All booking information is displayed in a ListBox.

4. Variables and Data Types

Variable| Data Type| Purpose
name| string| Guest name
age| int| Guest age
room| string| Room type
nights| int| Number of nights
guests| int| Number of guests
rate| double| Room price
roomCost| double| Room total
breakfastCost| double| Breakfast total
totalCost| double| Final cost

5. Room Cost Calculation

double roomCost = rate * nights;

This calculates the room price by multiplying the room rate by the number of nights.

6. Breakfast Cost Calculation

double breakfastCost = 0;

if (checkbreak.Checked)
{
    breakfastCost = 10 * guests * nights;
}

Breakfast costs $10 per guest per night. If the CheckBox is selected, the system calculates the breakfast cost.

7. Total Cost Calculation

double totalCost = roomCost + breakfastCost;

This adds the room cost and breakfast cost to calculate the final booking amount.

8. Display Booking Details

listbox1.Items.Add(
    "Booking Details\n\n" +
    "Guest Name: " + name + "\n" +
    "Guest Age: " + age + "\n" +
    "Room Type: " + room + "\n" +
    "Number of Nights: " + nights + "\n" +
    "Number of Guests: " + guests + "\n" +
    "Room Cost: $" + roomCost.ToString("0.00") + "\n" +
    "Breakfast Cost: $" + breakfastCost.ToString("0.00") + "\n" +
    "Total Cost: $" + totalCost.ToString("0.00")
);

This code displays all guest information and payment details inside the ListBox.

9. Important C# Concepts

- if statement: Checks whether a condition is true.
- CheckBox: Allows users to select an option.
- double: Stores decimal numbers.
- string: Stores text.
- int: Stores whole numbers.
- Items.Add(): Adds information to a ListBox.
- ToString(): Converts values into text.
- \n: Moves information to a new line.
- Multiplication (*): Calculates costs.
- Addition (+): Adds the costs together.

10. Example Calculation

Assume:

- Room Rate = $50
- Number of Nights = 3
- Number of Guests = 2
- Breakfast = Selected

Room Cost:

$50 × 3 = $150

Breakfast Cost:

$10 × 2 × 3 = $60

Total Cost:

$150 + $60 = $210

11. Expected Output

BOOKING DETAILS

Guest Name: Ahmed
Guest Age: 22
Room Type: Deluxe
Number of Nights: 3
Number of Guests: 2
Room Cost: $150.00
Breakfast Cost: $60.00
Total Cost: $210.00

12. Conclusion

The Hotel Booking System is a simple C# Windows Forms project that demonstrates the use of variables, data types, conditional statements, CheckBoxes, mathematical calculations, and ListBox controls.

It helps users manage hotel reservations and calculate booking costs easily and efficiently.

Technology Used: C#
Platform: Windows Forms
IDE: Visual Studio