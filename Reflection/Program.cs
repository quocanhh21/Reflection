using AutoMapper;
using System;
using System.Reflection;
namespace Reflection
{
    public class Program
    {
        //public static void Copy(Customer customer,Employee employee)
        //{
        //    var parentProperties = customer.GetType().GetProperties();
        //    var childProperties = employee.GetType().GetProperties();

        //    foreach (var parentProperty in parentProperties)
        //    {
        //        foreach (var childProperty in childProperties)
        //        {
        //            if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType== childProperty.PropertyType)
        //            {
        //                childProperty.SetValue(employee, parentProperty.GetValue(customer));
        //                break;
        //            }
        //        }
        //    }

        //}
        private static void Main()
        {




            Customer customer = new Customer()
            {
                Id = 1,
                prop1 = "prop test 1",
                prop2 = "prop test 2",
                prop3 = "prop test 3",
                prop4 = "prop test 4",
                prop5 = "prop test 5",
                prop6 = "prop test 6",
                prop7 = "prop test 7",
                prop8 = "prop test 8",
                prop9 = "prop test 9",
                prop10 = "prop test 10",
                prop11 = "prop test 11",
                prop12 = "prop test 12",
                prop13 = "prop test 13",
                prop14 = "prop test 14",
                prop15 = "prop test 15",
            };
            Employee employee = new Employee();


            Type T = Type.GetType("Reflection.Customer");
            Type TDes = Type.GetType("Reflection.Employee");

            Console.WriteLine("Properties in Employe Class");
            PropertyInfo[] Tproperties = T.GetProperties();
            Console.WriteLine("Properties in Employe Class");
            PropertyInfo[] TDesproperties = TDes.GetProperties();
            foreach (PropertyInfo property in Tproperties)
            {

                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("------------------");
            foreach (PropertyInfo property in TDesproperties)
            {

                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("---------------");
            foreach (var customerProperty in Tproperties)
            {
                foreach (var employeeProperty in TDesproperties)
                {
                    if (customerProperty.PropertyType.Name == employeeProperty.PropertyType.Name)
                    {
                        employeeProperty.SetValue(employee, customerProperty.GetValue(customer,null));
                        break;
                    }
                }
            }
            foreach (var property in TDesproperties)
            {

                Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer));
            }

         
          



            ////Type T = Type.GetType("Reflection.Customer");
            //Type T = typeof(Customer);


            //Type TDes = typeof(Employee);
            //PropertyInfo[] parentProperties = customer.GetType().GetProperties();
            //PropertyInfo[] childProperties = employee.GetType().GetProperties();

            ////Console.WriteLine("Properties in Customer Class");
            ////PropertyInfo[] customerProperties = T.GetProperties();
            ////Console.WriteLine("Properties in Employee Class");
            ////PropertyInfo[] employeeProperties = TDes.GetProperties();
            ////foreach (var property in parentProperties)
            ////{

            ////    Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer));
            ////}
            //Console.WriteLine("------------");

            //foreach (var property in childProperties)
            //{

            //    Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer));
            //}
            //foreach (var customerProperty in customerProperties)
            //{
            //    foreach (var employeeProperty in employeeProperties)
            //    {
            //        if (customerProperty.PropertyType.Name == employeeProperty.PropertyType.Name)
            //        {
            //            employeeProperty.SetValue(employee, customerProperty.GetValue(customer));
            //            break;
            //        }
            //    }
            //}
            //foreach (var property in employeeProperties)
            //{

            //    Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer));
            //}
            ////Console.WriteLine();

        }
    }
    public class Customer
    {
        public int Id { get; set; }

        public string prop1 { get; set; }

        public string prop2 { get; set; }

        public string prop3 { get; set; }

        public string prop4 { get; set; }

        public string prop5 { get; set; }

        public string prop6 { get; set; }

        public string prop7 { get; set; }

        public string prop8 { get; set; }

        public string prop9 { get; set; }

        public string prop10 { get; set; }

        public string prop11 { get; set; }

        public string prop12 { get; set; }

        public string prop13 { get; set; }

        public string prop14 { get; set; }

        public string prop15 { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string prop1 { get; set; }

        public string prop2 { get; set; }

        public string prop3 { get; set; }

        public string prop4 { get; set; }

        public string prop5 { get; set; }

        public string prop6 { get; set; }

        public string prop7 { get; set; }

        public string prop8 { get; set; }

        public string prop9 { get; set; }

        public string prop10 { get; set; }

        public string prop11 { get; set; }

        public string prop12 { get; set; }

        public string prop13 { get; set; }

        public string prop14 { get; set; }

        public string prop15 { get; set; }

    }
}