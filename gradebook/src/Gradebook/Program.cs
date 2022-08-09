using System.Collections.Generic; // clasa pentru data structure, heap, liste etc

namespace Gradebook
{
    
    internal class Program
    {
        private static void Main(string[] args)
        {

            /*
            var p = new Program();
            Program.Main(args);
            // prin static eliminam proprietatea de obiect/functie
            */

            // Book book2 = null; // fara null la constructor avoid it!
            InMemmoryBook book2 = new InMemmoryBook("Alex");
            book2.AddGrade(25.53);

            // var book = new InMemmoryBook("Bogdan");
            IBook book = new DiskBook("Bogdan's Grade book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            //book.GradeAdded = null; // dont do it 

            //book.grades.Add(23.52); // nu e un best approach asa poate cineva sa bage date illegal :D
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);

            EnterGrades(book);

            var stats = book.GetStatistics();

            //book.Name = "";
            // book.cateogry nu merge fiindca cateogry e constanta 
            System.Console.WriteLine(InMemmoryBook.CATEGORY);
            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The lowest grade is {stats.High}, and the highest is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The average grade is {stats.Average:N5}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");

            //Book.AddGrade(52.35); // nu merge daca methoda nu e static

            /* var  x = 34.1;
             var  y = 35.1;   
             var result = x + y;
             System.Console.WriteLine(result);
             */

            //double[] numbers = new double[3];
            //var numbers = new[] /*double[]*/ {12.7, 10.3, 6.11, 4.1};
            //numbers[0] = 12.7;
            //numbers[1] = 10.3;
            //numbers[2] = 6.11;

            //var result = numbers[0];
            //result += numbers[1];
            //result += numbers[2];
            /*var result = 0.0;

            foreach(var number in numbers)
            {
                result += number;
            }
            System.Console.WriteLine(result);
            result = 0.0;
            */

            //var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};;
            //grades.Add(56.1);


            //Console.WriteLine("Hello " + args[0] + "!");
            // string interpolation 
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }

        private static void EnterGrades(/* InMemmoryBook nu se mai foloseste, deoarece stim ca avem classa de baza Book */ IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Enter your grade or write q to exit. ");
                var inputGrade = Console.ReadLine();

                if (inputGrade == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(inputGrade);
                    book.AddGrade(grade);
                    //System.Console.WriteLine("Your grade has been added");
                }
                catch (ArgumentException ex) // declaram exceptia ex
                {
                    System.Console.WriteLine(ex.Message);
                    //throw; // rethrow the exception and it need to be catch again
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally // usually close a file or a network socket
                {
                    System.Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sneder, EventArgs e)
        {
            System.Console.WriteLine("A grade was added");
        }
    }


}