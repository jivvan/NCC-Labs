using Npgsql;
using models;
using System.Collections.Generic;

namespace data;
public class StudentRepository
{
    private readonly string _connectionString;

    public StudentRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddStudent(Student student)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("INSERT INTO Students (FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)", conn))
            {
                cmd.Parameters.AddWithValue("FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("LastName", student.LastName);
                cmd.Parameters.AddWithValue("Age", student.Age);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<Student> GetStudents()
    {
        var students = new List<Student>();

        using (var conn = new NpgsqlConnection(_connectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("SELECT * FROM Students", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Age = reader.GetInt32(3)
                    });
                }
            }
        }

        return students;
    }
}