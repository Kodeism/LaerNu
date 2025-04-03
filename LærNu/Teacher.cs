using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LærNu
{
    internal class Teacher: User
    {
        public string TeacherID {  get; set; }
        private List<string> Certifikater {  get; set; }
        private List<string> OwnedCourses { get; set; }
        public Teacher(string name, string email, string password, string teacherID, string userID) : base(name, email, password, userID)
        {
            TeacherID = teacherID;
            Certifikater = new List<string>();
            OwnedCourses = new List<string>();
        }
        public Teacher(User user, string teacherID) : base(user.Name, user.Email, user.Password, user.UserID)
        {
            TeacherID = teacherID;
            Certifikater = new List<string>();
            OwnedCourses = new List<string>();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Owned Courses: {string.Join(", ", OwnedCourses)}");
            Console.WriteLine($"Certificates: {string.Join(", ", Certifikater)}");
            Console.WriteLine($"TeacherID: {TeacherID}");
            Console.WriteLine();
        }
        public void AddOwned(Course course)
        {
            if(!(OwnedCourses.Contains(course.CourseID)))
            {
                OwnedCourses.Add(course.CourseID);
                Console.WriteLine($"Course: '{course.Name}' is now taught by teacher: {Name}...");
                course.AddTeacher(this);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Course: '{course.Name}' is already taught by teacher: {Name}...");
                Console.WriteLine();
            }
        }
        public void RemoveOwned(Course course)
        {
            if(OwnedCourses.Contains(course.CourseID))
            {
                OwnedCourses.Remove(course.CourseID);
                Console.WriteLine($"Course: '{course.Name}' is no longer taught by teacher: {Name}");
                course.RemoveTeacher(this);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Course: '{course.Name}' is no longer taught by teacher: {Name}");
                Console.WriteLine();
            }
        }
        public void AddCert(string cert)
        {
            if(!(Certifikater.Contains(cert)))
            {
                Certifikater.Add(cert);
                Console.WriteLine($"Certificate: '{cert}' has been added to teacher: {Name}'s certificates...");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Certificate: '{cert}' is already among teacher: {Name}'s certificates...");
                Console.WriteLine();
            }
        }
        public void RemoveCert(string cert)
        {
            if(Certifikater.Contains(cert))
            {
                Certifikater.Remove(cert);
                Console.WriteLine($"Certificate: '{cert}' has been removed from teacher: {Name}'s certificates...");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Certificate: '{cert}' is not among teacher: {Name}'s certificates...");
                Console.WriteLine();
            }
        }


    }
}
