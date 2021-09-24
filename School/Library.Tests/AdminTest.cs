using System;
using Xunit;
using FluentAssertions;

namespace Library.Tests
{
// {public class TCourse
// {
//     private TeacherCourse _Tcourse;
//     public TCourse()
//     {
//         _Tcourse = new TeacherCourse("","");
//     }
    public class AdminTest
{

    [Fact]
    public void TeacherObjectShouldDisplayFullName()
    {
        //Arrange
        Teacher teacher = new() { First = "Emily", Last = "White" };
        // Act
        string fullName = teacher.ToString();
        // Assert
        fullName.Should().Be("Emily White");

    }
    [Fact]

    public void TeacherIsAssignedToCourse()
    {
        //Arrange
        Teacher teacher = new() { First = "Emily", Last = "White" };
        //Act
        teacher.AddTeacherCourse("Algebra");
        //Assert
        teacher.Courses.Should().HaveCount(1);
        
    }
    [Fact]
  public void CourseIsStoredInCoursesList()
    {
        //Arrange
        Teacher teacher = new() { First = "Emily", Last = "White" };
        //Act
        teacher.AddTeacherCourse("Algebra");
        //Assert
        teacher.Courses[0].Should().Be("Algebra");
    
    }
   
}
}


