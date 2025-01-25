# Activity-2
Seconds Evaluation Application
Overview
This is a C# Windows Forms application created by Victor Perdue as part of CST-150 Activity 2. The purpose of the application is to evaluate a given number of seconds entered by the user and provide calculations for how many minutes, hours, and days are contained in that number.

Features
Input Validation: Ensures the user enters a valid integer.
Seconds Conversion:
Converts seconds into minutes, hours, and days.
Displays results dynamically based on user input.
Dynamic Feedback:
Provides color-coded messages for valid and invalid inputs.
Ensures user-friendly error handling and guidance.
Code Structure
1. Namespace and Form Class
The application resides in the CST_150_Activity_2 namespace.
The FrmSeconds class extends the Form class, providing the graphical user interface (GUI).
2. Key Components
TextBox (txtUserEntry): Accepts the number of seconds from the user.
Label (lblResults): Displays the results of the seconds conversion or error messages.
Event Handler (ManageSecondsEventHandler):
Handles the button click event to process the entered seconds.
Implements logic for converting seconds into minutes, hours, and days.
Provides error messages for invalid or insufficient input.
3. Constants
The application uses constants for conversions:

SecondsInMinutes = 60
SecondsInHours = 3600
SecondsInDays = 86400
4. Logic Flow
Validates the user input.
Checks if the seconds entered are sufficient for conversion into minutes, hours, and days.
Displays the corresponding calculations or error messages dynamically.
Prerequisites
Environment: Visual Studio with .NET Framework.
Language: C#.
Target Framework: Windows Forms Application.
How to Use
Run the Application: Start the application in Visual Studio by clicking the "Run" button.
Enter Seconds: Input a valid integer value in the text box.
Get Results:
The application calculates and displays:
Minutes if seconds >= 60.
Hours if seconds >= 3600.
Days if seconds >= 86400.
Error Handling:
If the input is invalid or less than 60 seconds, an error message is displayed in red.
