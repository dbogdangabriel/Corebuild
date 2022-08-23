using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args); //convention for delagte ca si parametru pui event-ul 2 parametri (first par is the sending,secodn is event argument )

    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        protected Book(string name) : base(name)
        {
        }

        // public virtual event GradeAddedDelegate GradeAdded; // dupa ce am pus virtual, e necesar override la metoda principala
        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        // public virtual /*la virtual putem sa zicem ca deja avem metoda*/Statistics GetStatistics()
        // {
        //     throw new NotImplementedException();
        // }

        public abstract Statistics GetStatistics();

    }

    public class InMemmoryBook : Book/*, IBook // daca vreau doar la classa asta interfata*/ // cand primesti un membru abstrat ne trebuie o metoda noua
    {

        // explicit constructor, which will appear in the class
        public InMemmoryBook(string name) : base(name) // reference my base class, trimitem numele de la book si la clasa de baza
        {
            // const int x = 3;
            // x++; // nu se poate 

            //category = "";
            // nu are return type 
           // grades = new List<double>(); // comentam pentru 
            Name = name; // punem this go to the name and add the right name, il folosim cand avem acelasi "nume" la call si in functie
        }

        public void AddGrade(char letter)
        {
            // if(letter == 'A')
            // {
            //     AddGrade(90);
            // }
            // else if(letter == 'B')
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        // doua metode cu acelasi nume, method overloading, daca punem parametru diferit la una method overriding 

        public override /* ovveride the base class method*/ void AddGrade(double grade)
        {
            // if (grade == 90.0)
            // {

            // }

            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                //Console.WriteLine("Invalid value");
                throw new ArgumentException($"Invalid {nameof(grade)}"); // daca schimbam parametrul la metoda il schimbam si la trow 
            }


        }

        public override event /* keyword event pentru declansarea interactiuni*/ GradeAddedDelegate GradeAdded; // just a field in the book class


        public override Statistics GetStatistics() //fiindca avem void facem o classa noua statistics sa trimitem datele si punem in loc de void numele clasei
        {
            var result = new Statistics();


            // foreach(var grade in grades)
            // {   
            //     result.High = Math.Max(grade, result.High);
            //     result.Low = Math.Min(grade, result.Low);
            //     result.Average += grade;
            // }

            // var index = 0;
            // do // executing at least once 
            // {   
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index += 1;
            // } while(index < grades.Count);

            // while(index < grades.Count)
            // {   
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index += 1;
            // } 

            // for(var index = 0; index < grades.Count; index++)
            // {   
            //     if(grades[index] == 42.1) 
            //     {
            //         break; // break the loop :D
            //         // continue // next index 
            //         // goto done "label"
            //     }

            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            // } 
            for (var index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);


            }
            //done:
            return result;
        }


        //public List<double> grades;  // punem public sa puntem folosii book.grades ca sa adauga direct grades 
        //static private List<double> grades; // protectie, fara injection :D 
        // daca e static o sa avem doar un field. therefore only 1 book. simple static negate OOP
        private List<double> grades; // protectie, fara injection :D
                                     //private string name; // ca sa putem adauga un name fiind private, il adaugam la constrcutorul book, deoarece vor fi nevoiti  


        //acces modifier 
        // public string Name 
        // {
        //     get
        //     {
        //         return name; //name.ToUpper();
        //     }
        //     set
        //     {
        //         if(String.IsNullOrEmpty(value))
        //         {
        //         name = value; //implicit variable named value, which is the incoming variable 
        //         }
        //     }


        // }

        // // the backing field which backs our get-set 
        // public string name; // pentru test, in plus numele la public sunt cu litera mare

        // public string Name
        // {
        //     get;
        //     //private set; // nu putem seta valori 
        //     set;
        // } // public string Name; diferenta dintre cele doua este la reflection and serialization la runtime se uita la fields

        //readonly string category = "Science";
        public const string CATEGORY = "Science"; // daca e const nu poti modifica in constructor. daca e constanta e de pereferat sa fie uppercase scrisa

    }

    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            // File.AppendText("GradeOnDisk.text");
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                //folosind using, practic avem indirect writer.Close(); 
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {

                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }

            }



            return result;
        }
    }
}