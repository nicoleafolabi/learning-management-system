using System;
using System.Collections.Generic;

namespace Library
{
    public class Teacher
    {
        public List<string> Courses;
        public string First;
        public string Last;

        public override string ToString() => $"{First} {Last}";

        public Teacher()
        {
            Courses = new List<string>();
        }

        public void AddTeacherCourse(string course)
        {
            Courses.Add(course);
        }
    }
}