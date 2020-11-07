//using exampleAspReact.Data;
//using exampleAspReact.Models;
//using System;
//using System.Linq;

//namespace ContosoUniversity.Data
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(MyDbContext context)
//        {
//            context.Database.EnsureCreated(); // создание файла БД

//            // Look for any students.
//            if (context.User.Any())
//            {
//                return;   // DB has been seeded
//            }

//            var students = new User[]
//            {
//                new User{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
//                new User{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
//                new User{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
//                new User{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
//                new User{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
//                new User{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
//                new User{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
//                new User{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
//            };

//            context.User.AddRange(students);
//            context.SaveChanges();

//            var courses = new Course[]
//            {
//                new Course{CourseID=1050,Title="Chemistry",Credits=3},
//                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
//                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
//                new Course{CourseID=1045,Title="Calculus",Credits=4},
//                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
//                new Course{CourseID=2021,Title="Composition",Credits=3},
//                new Course{CourseID=2042,Title="Literature",Credits=4}
//            };

//            context.Courses.AddRange(courses);
//            context.SaveChanges();

//            var enrollments = new Enrollment[]
//            {
//                new Enrollment{UserID=1,CourseID=1050,Grade=Grade.A},
//                new Enrollment{UserID=1,CourseID=4022,Grade=Grade.C},
//                new Enrollment{UserID=1,CourseID=4041,Grade=Grade.B},
//                new Enrollment{UserID=2,CourseID=1045,Grade=Grade.B},
//                new Enrollment{UserID=2,CourseID=3141,Grade=Grade.F},
//                new Enrollment{UserID=2,CourseID=2021,Grade=Grade.F},
//                new Enrollment{UserID=3,CourseID=1050},
//                new Enrollment{UserID=4,CourseID=1050},
//                new Enrollment{UserID=4,CourseID=4022,Grade=Grade.F},
//                new Enrollment{UserID=5,CourseID=4041,Grade=Grade.C},
//                new Enrollment{UserID=6,CourseID=1045},
//                new Enrollment{UserID=7,CourseID=3141,Grade=Grade.A},
//            };

//            context.Enrollments.AddRange(enrollments);
//            context.SaveChanges();
//        }
//    }
//}