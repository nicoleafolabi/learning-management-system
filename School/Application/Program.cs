using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
           var data = Fetching.GetDataFromHttp().GetAwaiter().GetResult();
           foreach(var courses in data)
           {
               Console.WriteLine(courses);
           }
            //    Console.WriteLine("Enter a teacher first name");
            //    var teacherFirst= Console.ReadLine();
            //    Console.WriteLine("Enter a teacher first name");
            //    var teacherLast= Console.ReadLine();
            // //    Console.WriteLine($"{teacher.ToString()}");
            //   Console.WriteLine("Enter a teacher class");
            //    var teacherClass= Console.ReadLine();
            //    Teacher.AddTeacherCourse(teacherClass);

        }
    }
}
