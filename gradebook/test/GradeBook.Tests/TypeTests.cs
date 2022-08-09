
using Gradebook;

namespace GradeBook.Tests;

public delegate string WriteLogDelegate(string logMessage);


public class TypeTests
{

    int count = 0;
     [Fact]
     public void WriteLogDelegateCanPointToMethod()
     {
        //WriteLogDelegate log;
        WriteLogDelegate log = ReturnMessage;
        log += ReturnMessage; // count how many times i invoke this method 
        log += IncrementCount;
        // log = new WriteLogDelegate(ReturnMessage);
        //log = ReturnMessage;


        var result = log("Hello! ");
        //Assert.Equal ("Hello!", result);
        Assert.Equal(3, count);
     }

    string ReturnMessage(string message)
    {
        count++;
        return message;
    }

    string IncrementCount(string message)
    {
        count++;
        return message.ToLower();
    }

     [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "Bogdan";
        var upper = MakeUppercase(name);

        Assert.Equal("Bogdan", name);
        Assert.Equal("BOGDAN", upper);
    }

    private string MakeUppercase(string parameter)
    {
        // parameter.ToUpper(); // return a copy of the string with uppercase
        return parameter.ToUpper();
    }

    public class Person // it always be a point to the memory
    {

    }

    public struct Point //value 
    {

    }

    [Fact]
    public void ValueTypesAlsoPassByValue()
    {
        var x = GetInt();
        SetInt(ref x);
        Assert.Equal(42,x);
    }

    private void SetInt(ref int x) // pui click pe int si apesi f12 sa vezi daca e struct atunci e value type 
    {
        //string s = ""; // string e reference type, but behaves like a value type
        x = 42;    
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
        // arrange 
        var book1 = GetBook("Book 1");
        GetBookSetName(ref book1, "New Name"); // add ref to be  sure that you want to pass by ref
        // GetBookSetName(out book1, "New Name");

        Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetName(ref InMemmoryBook book, string name) // ref to pass by referinte 
    // private void GetBookSetName(out Book book, string name) 
    {
        book = new InMemmoryBook(name); // create new obj and copying the book1 value , cu out trebuie neaparat initializat un obiect 
        //book.Name = name;
    }

    
    [Fact]
    public void CSharpIsPassByValue()
    {
        // arrange 
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name"); // pass by value 

        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(InMemmoryBook book, string name)
    {
        book = new InMemmoryBook(name); // create new obj and copying the book1 value 
        //book.Name = name;
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        // arrange 
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name"); // pass by value 

        Assert.Equal("New Name", book1.Name);
    }

    private void SetName(InMemmoryBook book, string name)
    {
        book.Name = name;
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        // arrange 
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");


        // act

        // assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1,book2);

    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        // arrange 
        var book1 = GetBook("Book 1");
        var book2 = book1;


        // act

        // assert
        // Assert.Equal("Book 1", book1.Name);
        // Assert.Equal("Book 1", book2.Name);
        Assert.Same(book1,book2);
        Assert.True(Object.ReferenceEquals(book1, book2));
    }

    InMemmoryBook GetBook(string name) // object lowest base type in .net framework, pune book ca sa dam return a book
    {
        return new InMemmoryBook(name);
    }
}