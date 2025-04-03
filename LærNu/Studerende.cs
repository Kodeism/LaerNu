using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LærNu
{
    internal class User
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private List<string> Courses { get; set; }
        public User(string name, string email, string password, string userID)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Password = password;
            Courses = new List<string>();
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"UserID {UserID}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Courses: {string.Join(", ", Courses)}");
            Console.WriteLine();
        }
        public void AddCourse(Course course)
        {
            if(!(Courses.Contains(course.CourseID)))
            {
                Courses.Add(course.CourseID);
                Console.WriteLine($"Course: '{course.Name}' has been added to user: {Name}'s courses...");
                course.AddStudent(this);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Course: '{course.Name}' is already among user: {Name}'s courses...");
                Console.WriteLine();
            }
        }
        public void RemoveCourse(Course course)
        {
            if(Courses.Contains(course.CourseID))
            {
                Courses.Remove(course.CourseID);
                Console.WriteLine($"Course: '{course.Name}' has been removed from user: {Name}'s courses...");
                course.RemoveStudent(this);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Course: '{course.Name}' is not among user: {Name}'s courses...");
                Console.WriteLine();
            }
        }
    }
}
