using System;
using System.Collections.Generic;

namespace Lab01_Student
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentsMathCourse = new List<Student>();

            Student student1 = new Student("Jeremias", 5.0f);
            Student student2 = new Student("Matias", 5.0f);
            Student student3 = new Student("Helen", 3.0f);
            Student student4 = new Student("Girlnalda", 5.0f, 1.0f);
            Student student5 = new Student("Toby", 5.0f, 3.0f);

            studentsMathCourse.Add(student1);
            studentsMathCourse.Add(student2);
            studentsMathCourse.Add(student3);
            studentsMathCourse.Add(student4);
            studentsMathCourse.Add(student5);


            student1.UpdateGPA(3.3f);
            student1.UpdateGPA(5.3f);
            student1.UpdateGPA(4.3f);
            student1.UpdateGPA(2.3f);
            student1.UpdateGPA(4.3f);
            
            // iterate the students
            foreach (var student in studentsMathCourse)
            {
                Console.WriteLine(student);
            }
        }
    }
}
