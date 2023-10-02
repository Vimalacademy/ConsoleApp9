using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirstConsoleApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a new DbContext instance.
            using var context = new StudentContext();

            // Add a new student to the database.
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };
            context.Students.Add(student);

            // Save the changes to the database.
            await context.SaveChangesAsync();

            // Display a message to the console.
            Console.WriteLine($"Student {student.FirstName} {student.LastName} has been added to the database.");
        }
    }
}
public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}