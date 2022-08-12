using NinjaDomain.Classes;
using NinjaDomain.Classes.Enums;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>()); // stop entity framework to go in db initilisation, DONT DO IT in production 
            InsertNinja();
            InsertMultipleNinjas();
            SimpleNinjaQueries();
            QueryAndUpdateNinja();
            RetrieveDataWithFind();
            RetrieveDataWithStoredProc();
            DeleteNinja();
            InsertNinjaWithEquipment();
            Console.ReadKey();

        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "AlexaSan",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(1999, 09, 11),
                ClanId = 1
            };
            using (var context = new NinjaContext()) 
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }

        private static void InsertMultipleNinjas()
        {
            var ninja1 = new Ninja
            {
                Name = "GabrielSan",
                ServedInOniwaban = true,
                DateOfBirth = new DateTime(1999, 01, 31),
                ClanId = 1
            };
            var ninja2 = new Ninja
            {
                Name = "ElenaSan",
                ServedInOniwaban = true,
                DateOfBirth = new DateTime(1999, 09, 11),
                ClanId = 1
            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja> {ninja1, ninja2 });
                context.SaveChanges();
            }

        }

        private static void SimpleNinjaQueries()
        {
            using( var context = new NinjaContext())
            {
                //var ninjas = context.Ninjas.Where(n => n.Name == "Raphael"); // bring all of the ninjas as a list 
                var ninjas = context.Ninjas.Where(n => n.DateOfBirth >= new DateTime(1998,1,1))
                                            /* .FirstOrDefault()// only one ninja*/ ;
                //var query = context.Ninjas;
                // var someninjas = query.ToList();
                foreach (var ninja in ninjas) // the db will be open untill every item will be done  
                {
                    Console.WriteLine(ninja.Name);
                }
            }
        }

        private static void QueryAndUpdateNinja()
        {
            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.FirstOrDefault(); // use firstordefault for better performane and only one item
                ninja.ServedInOniwaban = (!ninja.ServedInOniwaban);
                context.SaveChanges(); 
            }
        }

        private static void QueryAndUpdateNinjaDisconnected()
        {
            Ninja ninja;
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                ninja = context.Ninjas.FirstOrDefault(); // use firstordefault for better performane and only one item

            }

            ninja.ServedInOniwaban = !ninja.ServedInOniwaban;

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();

            }

        }

        private static void RetrieveDataWithFind()
        {
            var keyval = 4; 
            using ( var context = new NinjaContext() )
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.Find(keyval);
                Console.WriteLine( "After #1: " + ninja.Name);

                var someNinja = context.Ninjas.Find(keyval);
                Console.WriteLine("After #2: " + someNinja.Name);
                ninja = null;
            }
        }

        private static void RetrieveDataWithStoredProc()
        {

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninjas = context.Ninjas.SqlQuery("exec GetOldNinjas"); // cand ai un query sql extern // in loc de foreach poti folosi tolist()
                foreach (var ninja in ninjas)
                {
                    Console.WriteLine(ninja.Name);
                }
            }
        }

        private static void DeleteNinja()
        {
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.FirstOrDefault(); // cand ai un query sql extern // in loc de foreach poti folosi tolist()
                //context.Ninjas.Remove(ninja);
                context.Entry(ninja).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        private static void InsertNinjaWithEquipment() 
        {
            using (var context = new NinjaContext())
            {
               context.Database.Log = Console.WriteLine;
                var ninja = new Ninja
                {
                    Name = "Kacy Catanzaro",
                    ServedInOniwaban = false,
                    DateOfBirth = new DateTime(1990, 1, 14),
                    ClanId = 1
                };

                var muscles = new NinjaEquipment
                {
                    Name = "Muscles",
                    Type = EquipmentType.Tool,
                };

                var spunk = new NinjaEquipment
                {
                    Name = "Spunk",
                    Type = EquipmentType.Weapon,
                };
                context.Ninjas.Add(ninja);
                ninja.EquipmentOwned.Add(muscles);
                ninja.EquipmentOwned.Add(spunk);

            }
        }

    }
}
