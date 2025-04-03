using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LærNu
{
    internal class Course
    {
        public string Name { get; set; }
        public string CourseID { get; set; }
        public double Price { get; set; }
        public string Subject { get; set; }
        private Dictionary<string,double> Ratings { get; set; }
        public int NumberofLessons { get; set; }
        public int Seats { get; set; }
        private List<string> StudentIDs { get; set; }
        private List<string> TeacherIDs { get; set; }
        public string Type { get; set; }
        public Course(string name, string courseID, double price, string subject, int numberofLessons, int seats, string type)
        {
            Name = name;
            CourseID = courseID;
            Price = price;
            Subject = subject;
            Ratings = new Dictionary<string,double>();
            NumberofLessons = numberofLessons;
            Seats = seats;
            Type = type;
            StudentIDs = new List<string>();
            TeacherIDs = new List<string>();
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"CourseID: {CourseID}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Number of Lessons: {NumberofLessons}");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Avg. Rating: {Ratings.Values.Sum()/Ratings.Count()}");
            Console.WriteLine($"Students: {string.Join(", ", StudentIDs)}");
            Console.WriteLine($"Teachers: {string.Join(", ", TeacherIDs)}");
        }
        public void AddStudent(User student)
        {
            if(!(StudentIDs.Contains(student.UserID)))
            {
                StudentIDs.Add(student.UserID);
                Console.WriteLine($"Student: '{student.Name}' has been added to the course: '{Name}'...");
            }
            else
            {
                Console.WriteLine($"Student: '{student.Name}' is already in the course: '{Name}'...");
            }
        }
        public void RemoveStudent(User student)
        {
            if(StudentIDs.Contains(student.UserID))
            {
                StudentIDs.Remove(student.UserID);
                Console.WriteLine($"Student: '{student.Name}' has been removed from the course: '{Name}'...");
            }
            else
            {
                Console.WriteLine($"Student: '{student.Name}' is not in the course: '{Name}'...");
            }
        }
        public void AddTeacher(Teacher teacher)
        {
            if(!(TeacherIDs.Contains(teacher.TeacherID)))
            {
                TeacherIDs.Add(teacher.TeacherID);
                Console.WriteLine($"Teacher: '{teacher.Name}' now teaches the course: '{Name}'...");
            }
            else
            {
                Console.WriteLine($"Teacher: '{teacher.Name}' is already teaching the course: '{Name}'...");
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            if(TeacherIDs.Contains(teacher.UserID))
            {
                TeacherIDs.Remove(teacher.UserID);
                Console.WriteLine($"Teacher: '{teacher.Name}' no longer teaches the course: '{Name}'...");
            }
            else
            {
                Console.WriteLine($"Teacher: '{teacher.Name}' does not teach the course: '{Name}'...");
            }
        }
        public void AddRating(User user,double rating)
        {
            if (Ratings.ContainsKey(user.UserID))
            {
                Ratings[user.UserID] = rating;
            }
            else
            {
                Ratings.Add(user.UserID, rating);
            }
        }
    }
}
