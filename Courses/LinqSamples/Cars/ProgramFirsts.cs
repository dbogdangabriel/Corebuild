using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class ProgramFirsts
    {
        static void Main(string[] args)
        {
            var cars = ProcessCars("fuel.csv");
            var manufacturers = ProcessManufacturer("manufacturers.csv");

            /* var query =
                 from car in cars
                 group car by car.Manufacturer.ToUpper() into manufacturer
                 orderby manufacturer.Key
                 select manufacturer;

                    var query2 =
                 cars.GroupBy(c => c.Manufacturer.ToUpper())
                     .OrderBy(g => g.Key);*/
            /*
                        var query =
                            from manufacturer in manufacturers
                            join car in cars on manufacturer.Name equals car.Manufacturer
                                into carGroup
                            orderby manufacturer.Name
                            select new
                            {
                                Manufacturer = manufacturer,
                                Cars = carGroup
                            } into result
                            group result by result.Manufacturer.Headquarters;
                        var query2 =
                manufacturers.GroupJoin(cars, m => m.Name, c => c.Manufacturer, (m, g) =>
                new
                {
                    Manufacturer = m,
                    Cars = g
                })
                //.OrderBy(m => m.Manufacturer.Name);
                .GroupBy(m => m.Manufacturer.Headquarters);
            */

            // instead of working with a collection of groups like we did before, where each group has a key property
            // that represents the value that I grouped on, I'm going to do a projection into a flat sequence of items

            var query =
                from car in cars
                group car by car.Manufacturer into carGroup
                select new
                {
                    Name = carGroup.Key,
                    Max = carGroup.Max(c => c.Combined),
                    Min = carGroup.Min(c => c.Combined),
                    Avg = carGroup.Average(c => c.Combined)
                } into result
                orderby result.Max descending
                select result;

            var query2 =
                cars.GroupBy(c => c.Manufacturer)
                    .Select(g =>
                    {
                        var results = g.Aggregate(new CarStatistics(),
                                (acc, c) => acc.Accumulate(c),
                                acc => acc.Compute());
                        return new
                        {
                            Name = g.Key,
                            Avg = results.Average,
                            Min = results.Min,
                            Max = results.Max,
                    };
           })
                    .OrderByDescending(r => r.Max);


            /*   foreach (var group in query)
               {
                   //Console.WriteLine($"{result.Key} has {result.Count()} cars");
                   *//*                Console.WriteLine($"{group.Manufacturer.Name} : {group.Manufacturer.Headquarters}");
                                   foreach (var car in group.Cars.OrderByDescending(c => c.Combined).Take(2))
                                   {
                                       Console.WriteLine($"\t {car.Name} : {car.Combined}");
                                   }*//*
                   Console.WriteLine($"{group.Key}");
                   foreach (var car in group.SelectMany(g => g.Cars)
                               .OrderByDescending(c => c.Combined)
                               .Take(3))
                   {
                       Console.WriteLine($"\t {car.Name} : {car.Combined}");
                   }
               }*/

            foreach (var result in query)
            {
                Console.WriteLine($"{result.Name}");
                Console.WriteLine($"\t Max: {result.Max}");
                Console.WriteLine($"\t Max: {result.Min}");
                Console.WriteLine($"\t Max: {result.Avg}");
            }

    /*var query = cars.OrderByDescending(c => c.Combined)
        .ThenBy(c => c.Name); // nu merge co orderby din nou fiindca nu l mai ia pe primu*/
    /*            var query =
                    from car in cars
                        //where car.Manufacturer == "BMW" && car.Year == 2016
                    join manufacturer in manufacturers
                        on new { car.Manufacturer, car.Year } 
                        equals
                        new { Manufacturer = manufacturer.Name, manufacturer.Year }
                    orderby car.Combined descending, car.Name ascending
                    select new
                    { // fara nume ii select anonym
                        // car.Manufacturer,
                        manufacturer.Headquarters,
                        car.Name,
                        car.Combined
                    };

                var query2 =
                    cars.Join(manufacturers,
                                c => new { c.Manufacturer, c.Year },
                                m => new { Manufacturer = m.Name, m.Year },
                                (c, m) => new
                                {
                                    m.Headquarters,
                                    c.Name,
                                    c.Combined
                                })
                        .OrderByDescending(c => c.Combined)
                        .ThenBy(c => c.Name);
    */

    /*         var top =
                 cars
                     .OrderByDescending(c => c.Combined)
                     .ThenBy(c => c.Name)
                     .Select(c => c)
                     .First(c => c.Manufacturer == "BMW" && c.Year == 2016);

             var result = cars.Select(c => new {c.Manufacturer,
                  c.Name, c.Combined});
             var result = cars.SelectMany(c => c.Name)
                                 .OrderBy(c => c);*/


    /*         foreach(var characters in result)
             {
                 Console.WriteLine(characters);
             }

    //Console.WriteLine(result);

    Console.WriteLine(top.Name); 
    foreach (var car in query2.Take(10))
    {
        Console.WriteLine($"{car.Headquarters} - {car.Name} : {car.Combined}");
    }
    */

}

private static List<Car> ProcessCars(string path)
{

    /*  from line in File.ReadAllLines(path).Skip(1)
         where line.Length > 1
         select Car.ParseFromCsv(line);  */
    var query =

        File.ReadAllLines(path)
                    .Skip(1) // skip header line
                    .Where(l => l.Length > 1) // skip the last row where is empty
                                              //.Select(l => Car.ParseFromCsv(l))
                    .ToCar();

    return query.ToList();
}

private static List<Manufacturer> ProcessManufacturer(string path)
{
    var query =
        File.ReadAllLines(path)
                    .Where(l => l.Length > 1) // skip the last row where is empty
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],
                            Year = int.Parse(columns[2])
                        };
                    });


    return query.ToList();
}
    }

    public class CarStatistics
{

    public CarStatistics()
    {
        Max = Int32.MinValue;
        Min = Int32.MaxValue;
    }
    public CarStatistics Accumulate(Car car)
    {
        Count += 1;
        Total += car.Combined;
        Max = Math.Max(Max, car.Combined);
        Min = Math.Min(Min, car.Combined);

        return this;
    }

    public CarStatistics Compute()
    {
        Average = Total / Count;
        return this;
    }

    public int Max { get; set; }
    public int Min { get; set; }
    public int Total { get; set; }
    public int Count { get; set; }
    public double Average { get; set; }
}

public static class CarExtensions
{
    public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
    {
        foreach (var line in source)
        {
            var columns = line.Split(',');

            yield return new Car
            {
                Year = int.Parse(columns[0]),
                Manufacturer = columns[1],
                Name = columns[2],
                Displacement = double.Parse(columns[3]),
                Cylinders = int.Parse(columns[4]),
                City = int.Parse(columns[5]),
                Highway = int.Parse(columns[6]),
                Combined = int.Parse(columns[7]),
            };

        }
    }
}
}
