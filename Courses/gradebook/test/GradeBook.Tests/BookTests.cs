
using Gradebook;

namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrades()
    {
        /*
        // arrange section where you put all the test data and values
        var x = 5;
        var y = 2;
        var expected = 7;

        // act section where you actually do smth.
        var actual = x + y;

        // api provide us aasert
        // assert smth. about a value  etc.
        Assert.Equal(expected, actual);
        */

        // arrange
        var book = new InMemmoryBook("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);
        book.AddGrade(105.0); // ? not working

        // act
        var result = book.GetStatistics();
        
        // assert
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);
        Assert.Equal('B', result.Letter);


    }
}