C# File Handling System – Create, Write, Clear and Delete Files

1. Introduction

This project demonstrates how to perform basic file handling operations using C# Windows Forms.

File handling allows a programmer to create files, write information into files, clear file contents, and delete files when they are no longer needed.

In this project, we use the "System.IO" namespace to work with text files.

The project contains three main button operations:

1. Create and Write File
2. Clear File Contents
3. Delete File

2. Technologies Used

- Programming Language: C#
- Framework: Windows Forms
- Namespace: System.IO
- File Type: Text File (.txt)
- IDE: Visual Studio

3. Importing the Required Namespace

using System.IO;

Explanation:

The "System.IO" namespace provides classes and methods for working with files and folders.

It allows us to use:

- "File": To create, write, and delete files.
- "StreamWriter": To write text into a file.
- "File.Exists()": To check whether a file exists.

---

4. Create and Write to a File

Code

private void button1_Click(object sender, EventArgs e)
{
    // Declare StreamWriter
    StreamWriter outputFile;

    // Create a new text file
    outputFile = File.CreateText("output.txt");

    // Write information into the file
    outputFile.WriteLine("Hello");
    outputFile.WriteLine("Welcome to Jamhuriya and C#");
    outputFile.WriteLine("My name is APDIQAFAR AHMED");
    outputFile.WriteLine("This is my 1ST file");

    // Close the file
    outputFile.Close();
}

Explanation

1. StreamWriter outputFile;

This declares a StreamWriter variable that is used to write text into a file.

2. File.CreateText("output.txt");

This creates a new text file called "output.txt".

If the file already exists, its previous contents are overwritten.

3. outputFile.WriteLine();

This method writes text into the file. Each "WriteLine()" creates a new line.

4. outputFile.Close();

This closes the file after writing and releases the resources used by the StreamWriter.

Expected Output

The file "output.txt" will contain:

Hello
Welcome to Jamhuriya and C#
My name is APDIQAFAR AHMED
This is my 1ST file

---

5. Clear ListBox and File Contents

Code

private void button4_Click(object sender, EventArgs e)
{
    // Clear the ListBox
    listBox1.Items.Clear();

    // Check if the file exists
    if (File.Exists("output.txt"))
    {
        // Clear all file contents
        File.WriteAllText("output.txt", "");
    }
}

Explanation

1. listBox1.Items.Clear();

This removes all items displayed inside the ListBox.

2. File.Exists("output.txt");

This checks whether the text file exists before trying to clear it.

3. File.WriteAllText("output.txt", "");

This removes all existing text from the file while keeping the file itself.

4. if statement

The "if" statement ensures that the file is cleared only when it exists.

Expected Result

- All ListBox items are removed.
- All text inside "output.txt" is cleared.
- The file itself remains available.

---

6. Delete the Text File

Code

private void button3_Click(object sender, EventArgs e)
{
    // Check if the file exists
    if (File.Exists("output.txt"))
    {
        // Delete the text file
        File.Delete("output.txt");

        MessageBox.Show("File deleted successfully!");
    }
    else
    {
        MessageBox.Show("File does not exist!");
    }
}

Explanation

1. File.Exists("output.txt");

Checks whether the specified file is available.

2. File.Delete("output.txt");

Deletes the entire text file from the computer.

3. MessageBox.Show();

Displays a message to inform the user about the result.

4. else

Runs when the file does not exist.

Expected Result

- The "output.txt" file is permanently deleted.
- The user receives a confirmation message.

---

7. Difference Between the Main Methods

Method| Purpose
File.CreateText()| Creates a text file
WriteLine()| Writes text into a file
Close()| Closes the file
File.Exists()| Checks if a file exists
File.WriteAllText()| Writes or replaces file contents
Items.Clear()| Clears ListBox items
File.Delete()| Deletes the entire file

8. How the Project Works

The project follows these steps:

1. The user clicks the Create button.
2. The program creates "output.txt".
3. The program writes information into the text file.
4. The user clicks the Clear button.
5. The ListBox and file contents are cleared.
6. The user clicks the Delete button.
7. The entire text file is deleted.

9. Important Concepts Learned

Through this project, we learn:

- How to create a text file using C#.
- How to write information into a file.
- How to use StreamWriter.
- How to close a file properly.
- How to check whether a file exists.
- How to clear ListBox items.
- How to remove existing file contents.
- How to delete a text file.
- How to use conditional statements ("if" and "else").
- How to display messages using MessageBox.

10. Conclusion

In conclusion, this C# Windows Forms project demonstrates the basic concepts of file handling.

It explains how to create, write, clear, and delete text files using the "System.IO" namespace.

These operations are important in software development because many applications need to store, manage, update, and remove information from files.

Project Summary: Create File → Write Data → Clear Contents → Delete File.