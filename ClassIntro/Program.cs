using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //add an object to class which is created in below
            Course course1 = new Course();
            course1.CourseName = "c#";
            course1.CourseInstructor = "Engin";
            course1.WatchingScale =" 50 " ;
        }
    }

    class Course 
        //create a new class
    {
        public string CourseName { get; set; } 
        public string CourseInstructor { get; set; }
        public string WatchingScale { get; set; }
    }
}
