# English Vocabulary Quiz

A timed English vocabulary quiz application developed using C# Windows Forms and Microsoft SQL Server. The application allows users to log in, practice English vocabulary, and track their scores.

## Features

- **User Login:** Authenticates users with their username and password.
- **Timed Vocabulary Quiz:** Challenges users to answer English vocabulary questions within 90 seconds.
- **Random Word Selection:** Displays randomly selected words from a SQL Server database.
- **Score Tracking:** Counts correctly answered words during each quiz session.
- **Skip Counter:** Tracks the number of skipped words.
- **Score History:** Saves users' scores to the database.
- **Leaderboard:** Displays quiz scores and associated user information.
- **Database Integration:** Uses ADO.NET to communicate with Microsoft SQL Server.

## Technologies Used

- C#
- .NET Framework 4.7.2
- Windows Forms (WinForms)
- Microsoft SQL Server
- ADO.NET
- SQL

## Database Setup

This project requires Microsoft SQL Server.

The application uses the following database tables:

- `Tbl_Uyeler_Kelime` — stores user account information.
- `kelimeler` — stores English vocabulary and Turkish translations.
- `Tbl_Skor_Kelime` — stores quiz scores associated with user IDs.

Before running the application:

1. Create the `SU_Project` database in SQL Server.
2. Create the required tables and populate the `kelimeler` table with vocabulary data.
3. Configure the database connection string in `App.config` to match your SQL Server instance.
4. Ensure that the database contains the expected columns and relationships.

**Note:** The application was originally configured to use a local SQL Server instance. You may need to update the connection settings before running it on another computer.

## How to Run

1. Clone or download this repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Configure the SQL Server connection string in `App.config`.
4. Ensure the required database tables and vocabulary records exist.
5. Build and run the application.

## Learning Objectives

This project helped me practice:

- Windows Forms application development with C#.
- SQL Server integration using ADO.NET.
- Parameterized SQL queries.
- User authentication and passing user IDs between forms.
- Saving and retrieving quiz scores.
- Implementing a timer-based quiz.

## Future Improvements

- Add password hashing for more secure authentication.
- Improve input validation and error handling.
- Add a more detailed score history and leaderboard.
- Separate database operations from the Windows Forms UI.
- Improve the vocabulary learning experience with difficulty levels and progress tracking.

## Project Status

Learning project — developed to practice C#, Windows Forms, and SQL Server database operations.
