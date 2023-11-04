using Class_Count;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class StudentDatabase
{
    private SQLiteConnection connection;

    public StudentDatabase()
    {
        // Initialize the SQLite database connection
        connection = new SQLiteConnection("Data Source=students.db;Version=3;");
        connection.Open();

        // Create a table to store students if it doesn't exist
        string createTableQuery = "CREATE TABLE IF NOT EXISTS Students " +
            "(ID INTEGER PRIMARY KEY AUTOINCREMENT, FirstName TEXT, LastName TEXT, Payment DATETIME, Sessions INTEGER)";

        SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
        command.ExecuteNonQuery();
    }

    // Method to insert a new student record
    public void InsertStudent(Student student)
    {
        string insertQuery = "INSERT INTO Students (FirstName, LastName, Payment, Sessions) " +
            "VALUES (@FirstName, @LastName, @Payment, @Sessions)";

        using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
        {
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Payment", student.Payment);
            command.Parameters.AddWithValue("@Sessions", student.Sessions);

            command.ExecuteNonQuery();
        }
    }

    // Method to retrieve a list of all students from the database
    public List<Student> GetAllStudents()
    {
        List<Student> students = new List<Student>();

        string selectQuery = "SELECT * FROM Students";

        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
        {
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Payment = DateTime.Parse(reader["Payment"].ToString()),
                        Sessions = int.Parse(reader["Sessions"].ToString())
                    };
                    students.Add(student);
                }
            }
        }

        return students;
    }

    // Method to update an existing student record
    public void UpdateStudent(int studentId, Student updatedStudent)
    {
        string updateQuery = "UPDATE Students " +
            "SET FirstName = @FirstName, LastName = @LastName, Payment = @Payment, Sessions = @Sessions " +
            "WHERE ID = @StudentID";

        using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
        {
            command.Parameters.AddWithValue("@FirstName", updatedStudent.FirstName);
            command.Parameters.AddWithValue("@LastName", updatedStudent.LastName);
            command.Parameters.AddWithValue("@Payment", updatedStudent.Payment);
            command.Parameters.AddWithValue("@Sessions", updatedStudent.Sessions);
            command.Parameters.AddWithValue("@StudentID", studentId);

            command.ExecuteNonQuery();
        }
    }

    // Method to delete a student record by ID
    public void DeleteStudent(int studentId)
    {
        string deleteQuery = "DELETE FROM Students WHERE ID = @StudentID";

        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
        {
            command.Parameters.AddWithValue("@StudentID", studentId);

            command.ExecuteNonQuery();
        }
    }

    // Dispose of the database connection when you're done with it
    public void Dispose()
    {
        connection.Close();
    }
}
