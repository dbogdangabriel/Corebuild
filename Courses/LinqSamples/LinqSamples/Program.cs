using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) =>
            {
                return x + y;
            };
            Action<int> write = x => Console.WriteLine(x);


            write(square(3));
            write(square(add(3,5)));

/*            Employee[] developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Alex"}
            };

            foreach (var person in developers)
            {
                Console.WriteLine(person.Name);
            }*/

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Alex"}
            };

            /*  Console.WriteLine(sales.Count());
              IEnumerator<Employee> enumerator = sales.GetEnumerator(); // or developers
              while(enumerator.MoveNext())
              {
                  Console.WriteLine(enumerator.Current.Name);
              }*/

            // anonymous function
            /*            foreach(var employee in developers.Where(
                            delegate(Employee employee)
                            {
                            return employee.Name.StartsWith("S");
                        }))*/
            foreach (var employee in developers.Where(
                e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }
            // another query
            var query = developers.Where(e => e.Name.Length == 5)
                .OrderBy(e => e.Name)
                .Select(e => e);// .Count(); // does nothing 
            
            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;
            query2.Count();

            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }
        }

/*        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }*/
    }
}
