using System;
using Xunit;
using FluentAssertions;

namespace Library.Tests
{
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
        //  [Fact]
        //  public void TeacherIsAssignedToClass()
        //  {
        //      //Arrange
        //      Teacher teacher = new() { First = "Emily", Last = "White" };
        //      //Act
        //       string teacherclass = "Algebra";
        //       teacher.assignClass("Algebra");
        //      //Assert
        //       teacher.getClass().Should().Be(teacherclass);



    }
}


