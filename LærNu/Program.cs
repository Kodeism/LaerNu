using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using LærNu;

User PS = new User("Pia Stanø", "Pia.S@mail.com","76GFD@LKR","54-65.3243534");
Teacher MI = new Teacher("Malte Iversen","Malte.Iversen@mail.com","32s65KS91@","43-32.325441","43-32.544312");
PS.Display();
//OUTPUT
//Name: Pia Stanø
//UserID 54-65.3243534
//Email: Pia.S @mail.com
//Password: 76GFD @LKR
//Courses:
MI.Display();
//OUTPUT:
//Name: Malte Iversen
//UserID 43-32.544312
//Email: Malte.Iversen @mail.com
//Password: 32s65KS91@
//Courses:
//Owned Courses:
//Certificates:
//TeacherID: 43-32.325441

Course smurf = new Course("How to become a Smurf", "43.431123", 43, "Magic", 10, 5000, "Physical");
PS.AddCourse(smurf);
//OUTPUT:
//Course: 'How to become a Smurf' has been added to student: Pia Stanø's courses...
//Student: 'Pia Stanø' has been added to the course: 'How to become a Smurf'...
PS.AddCourse(smurf);
//OUTPUT:
//Course: 'How to become a Smurf' is already among student: Pia Stanø's courses...
smurf.AddStudent(PS);
//OUTPUT:
//Student: 'Pia Stanø' is already in the course: 'How to become a Smurf'...
Course voice = new Course("Learn to listen: Turn off your ears", "54.234234", 65, "Medicin", 32, 23, "Online");
PS.AddCourse(voice);
//OUTPUT:
//Course: 'Learn to listen: Turn off your ears' has been added to student: Pia Stanø's courses...
//Student: 'Pia Stanø' has been added to the course: 'Learn to listen: Turn off your ears'...
PS.RemoveCourse(voice);
//OUTPUT:
//Course: 'Learn to listen: Turn off your ears' has been removed from student: Pia Stanø's courses...
//Student: 'Pia Stanø' has been removed from the course: 'Learn to listen: Turn off your ears'...
PS.RemoveCourse(voice);
//OUTPUT:
//Course: 'Learn to listen: Turn off your ears' is not among student: Pia Stanø's courses...
voice.RemoveStudent(PS);
//OUTPUT:
//Student: 'Pia Stanø' is not in the course: 'Learn to listen: Turn off your ears'...
PS.Display();
//OUTPUT:
//Name: Pia Stanø
//UserID 54-65.3243534
//Email: Pia.S @mail.com
//Password: 76GFD @LKR
//Courses: 43.431123

Course hy = new Course("Hygiene Part 1: How to Shower", "43.653433", 54, "Cleaning", 54, 76, "Physical");
MI.AddCourse(hy);
//OUTPUT:
//Course: 'Hygiene Part 1: How to Shower' has been added to student: Malte Iversen's courses...
//Student: 'Malte Iversen' has been added to the course: 'Hygiene Part 1: How to Shower'...
Course gi = new Course("How I Became the World's Smallest Giant", "65.3212132", 12, "Myths", 16, 43, "Online");
MI.AddOwned(gi);
//OUTPUT:
//Course: 'How I Became the World's Smallest Giant' is now taught by teacher: Malte Iversen...
//Teacher: 'Malte Iversen' now teaches the course: 'How I Became the World's Smallest Giant'...
MI.AddCert("Tiny Gigantism");
//OUTPUT:
//Certificate: 'Tiny Gigantism' has been added to teacher: Malte Iversen's certificates...
MI.Display();
//OUTPUT:
//Name: Malte Iversen
//UserID 43-32.544312
//Email: Malte.Iversen@mail.com
//Password: 32s65KS91@
//Courses: 43.653433
//Owned Courses: 65.3212132
//Certificates: Tiny Gigantism
//TeacherID: 43-32.325441

Teacher Ps = new Teacher(PS, "23-54.34213");
Ps.Display();
//OUTPUT:
//Ps.Display();
//Name: Pia Stanø
//UserID 54-65.3243534
//Email: Pia.S@mail.com
//Password: 76GFD @LKR
//Courses:
//Owned Courses:
//Certificates:
//TeacherID: 23-54.34213



voice.Display();
//OUTPUT:
//Name: Learn to listen: Turn off your ears
//Type: Online
//CourseID: 54.234234
//Price: 65
//Subject: Medicin
//Number of Lessons: 32
//Seats: 23
//Avg.Rating: NaN
//Students:
//Teachers:

gi.Display();
//OUTPUT:
//Name: How I Became the World's Smallest Giant
//Type: Online
//CourseID: 65.3212132
//Price: 12
//Subject: Myths
//Number of Lessons: 16
//Seats: 43
//Avg.Rating: NaN
//Students:
//Teachers: 43 - 32.325441

smurf.AddRating(5);
smurf.AddRating(3.2);

smurf.Display();
//OUTPUT:
//Name: How to become a Smurf
//Type: Physical
//CourseID: 43.431123
//Price: 43
//Subject: Magic
//Number of Lessons: 10
//Seats: 5000
//Avg.Rating: 4,1
//Students: 54 - 65.3243534
//Teachers:
