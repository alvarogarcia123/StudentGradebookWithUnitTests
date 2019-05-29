using System;
using Xunit;

namespace StudentGradebook.Tests
{
    public class GraderTests
    {
        [Theory]
        [InlineData(95.7, 'A')]
        [InlineData(83, 'B')]
        [InlineData(110, 'A')]
        [InlineData(-100, 'F')]
        [InlineData(79.99, 'C')]
        [InlineData(60, 'D')]
        [InlineData(59.9, 'F')]
        [InlineData(0, 'F')]
        public void ShouldGradeAssignment(double numericGrade, char expectedLetterGrade)
        {
            // Arrange
            Grader grader = new Grader();

            // Act
            char actual = grader.GradeAssignment(numericGrade);

            // Assert
            Assert.Equal(expectedLetterGrade, actual);
        }
    }
}
