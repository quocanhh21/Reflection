using AutoMapper;
using System;
using System.Reflection;
namespace Reflection
{
    public class Program
    {
        private static void Main()
        {

          


            //initializing the mapper
            var config = new MapperConfiguration(cfg => 
                cfg.CreateMap<Customer, Employee>()
            );

            Type T = Type.GetType("Reflection.Customer");



            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {

                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();

            // Create object
            Customer cus = new Customer()
            {
                CId = 1,
                Cprop1 = "prop test 1",
                Cprop2 = "prop test 2",
                Cprop3 = "prop test 3",
                Cprop4 = "prop test 4",
                Cprop5 = "prop test 5",
                Cprop6 = "prop test 6",
                Cprop7 = "prop test 7",
                Cprop8 = "prop test 8",
                Cprop9 = "prop test 9",
                Cprop10 = "prop test 10",
                Cprop11 = "prop test 11",
                Cprop12 = "prop test 12",
                Cprop13 = "prop test 13",
                Cprop14 = "prop test 14",
                Cprop15 = "prop test 15",
            };

            ////Using automapper
            var mapper = new Mapper(config);
            var employee = mapper.Map<Employee>(cus);

            Console.WriteLine(employee.Eprop1);


            //Console.WriteLine(emp);
        }
    }
    public class Customer
    {
        public int CId { get; set; }

        public string Cprop1 { get; set; }

        public string Cprop2 { get; set; }

        public string Cprop3 { get; set; }

        public string Cprop4 { get; set; }

        public string Cprop5 { get; set; }

        public string Cprop6 { get; set; }

        public string Cprop7 { get; set; }

        public string Cprop8 { get; set; }

        public string Cprop9 { get; set; }

        public string Cprop10 { get; set; }

        public string Cprop11 { get; set; }

        public string Cprop12 { get; set; }

        public string Cprop13 { get; set; }

        public string Cprop14 { get; set; }

        public string Cprop15 { get; set; }
    }
    public class Employee
    {
        public int EId { get; set; }
        public string Eprop1 { get; set; }

        public string Eprop2 { get; set; }

        public string Eprop3 { get; set; }

        public string Eprop4 { get; set; }

        public string Eprop5 { get; set; }

        public string Eprop6 { get; set; }

        public string Eprop7 { get; set; }

        public string Eprop8 { get; set; }

        public string Eprop9 { get; set; }

        public string Eprop10 { get; set; }

        public string Eprop11 { get; set; }

        public string Eprop12 { get; set; }

        public string Eprop13 { get; set; }

        public string Eprop14 { get; set; }

        public string Eprop15 { get; set; }

    }
}