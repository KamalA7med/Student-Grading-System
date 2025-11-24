# Student Grading System

A simple C# console application to manage and display student grades, calculate averages, and generate a summary report of students' success or failure.

---

## Features

- Add multiple students with their grades.
- Supports grades of generic types (e.g., integers, doubles).
- Calculates the average grade for each student.
- Checks if a student passes or fails based on a defined passing degree.
- Displays a formatted report showing:
  - Student Name
  - Average Grade
  - Status (Success/Failed)
- Counts the number of passing and failing students.

---

## Project Structure

- `Program.cs`:  
  Main program that handles input and triggers the report generation.

- `Student.cs`:  
  Represents a student with a name and a list of grades.

- `Grades_Report.cs`:  
  Contains methods to generate and display the grading report.

- `Student_Grading_System.cs`:  
  Handles the calculation and display logic of grades.

- `Del.cs` (Delegate):  
  Defines a delegate to handle header display customization.

---

## How to Use

1. Run the program.
2. Enter the student's name.
3. Enter grades for six subjects (0–100).
4. Choose whether to add another student.
5. After entering all students, the program generates a detailed report including:
   - Each student's average grade.
   - Pass/fail status.
   - Total number of passing and failing students.

---

