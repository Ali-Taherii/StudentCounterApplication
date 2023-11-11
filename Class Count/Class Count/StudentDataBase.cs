using Class_Count;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

public class StudentDatabase : IDisposable
{
    private SQLiteConnection connection;

    public StudentDatabase()
    {
        // Initialize the SQLite database connection
        connection = new SQLiteConnection("Data Source=students.db;Version=3;");
        connection.Open();

        // Create a table to store students if it doesn't exist
        string createTableQuery = "CREATE TABLE IF NOT EXISTS Students " +
            "(Id INTEGER PRIMARY KEY, FirstName TEXT, LastName TEXT, Payment DATETIME, Sessions INTEGER)";

        SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
        command.ExecuteNonQuery();
    }

    // Method to insert a new student record
    public void InsertStudent(Student student)
    {
        string insertQuery = "INSERT INTO Students (Id, FirstName, LastName, Payment, Sessions) " +
            "VALUES (@Id, @FirstName, @LastName, @Payment, @Sessions)";

        using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
        {
            command.Parameters.AddWithValue("@Id", student.getId());
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Payment", student.Payment);
            command.Parameters.AddWithValue("@Sessions", student.Sessions);

            command.ExecuteNonQuery();
        }
        this.ExportStudentsToTextFile("student.txt");

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
                    student.SetId(int.Parse(reader["Id"].ToString()));

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
            "WHERE Id = @StudentID";

        using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
        {
            command.Parameters.AddWithValue("@FirstName", updatedStudent.FirstName);
            command.Parameters.AddWithValue("@LastName", updatedStudent.LastName);
            command.Parameters.AddWithValue("@Payment", updatedStudent.Payment);
            command.Parameters.AddWithValue("@Sessions", updatedStudent.Sessions);
            command.Parameters.AddWithValue("@StudentID", studentId);

            command.ExecuteNonQuery();
        }
        this.ExportStudentsToTextFile("student.txt");

    }

    // Method to delete a student record by ID
    public void DeleteStudent(int studentId)
    {
        string deleteQuery = "DELETE FROM Students WHERE Id = @StudentID";

        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
        {
            command.Parameters.AddWithValue("@StudentID", studentId);

            command.ExecuteNonQuery();
        }
        this.ExportStudentsToTextFile("student.txt");
    }

    // Method to retrieve one student's ID from the database based on the name
    public int findStudentId(string name)
    {
        foreach (Student student in this.GetAllStudents())
        {
            string fullName = student.FirstName + " " + student.LastName;
            if (fullName == name)
            {
                return student.getId();
            }
        }
        return 0;
    }

    // Method to retrieve one student from the database based on the ID
    public Student findStudent(int id)
    {
        foreach (Student student in this.GetAllStudents())
        { if (student.getId() == id) return student; }
        return null;
    }

    // Method to retrieve a list of all students from the database and export to a text file
    public void ExportStudentsToTextFile(string filePath)
    {
        List<Student> students = GetAllStudents();



        using (StreamWriter writer = new StreamWriter(filePath))
        {
            if (students.Count == 0)
            {
                // Handle the case where there are no students to export
                writer.WriteLine("No students to show!");
                return;
            }
            foreach (Student student in students)
            {
                writer.WriteLine($"ID:  {student.getId()}");
                writer.WriteLine($"First Name: {student.FirstName}");
                writer.WriteLine($"Last Name: {student.LastName}");
                writer.WriteLine($"Payment Date: {student.Payment}");
                writer.WriteLine($"Remaining Sessions: {student.Sessions}");
                writer.WriteLine(); // Add a blank line to separate entries
            }
        }
    }

    // Dispose of the database connection when you're done with it
    public void Dispose()
    {
        if (connection != null)
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
