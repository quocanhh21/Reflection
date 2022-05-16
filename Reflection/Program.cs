using System.Reflection;
namespace Reflection
{
    public class Program
    {
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
            Customer customer2 = new Customer();

            Type T= typeof(Customer);

            PropertyInfo[] customerProperties = T.GetProperties();

            Console.WriteLine("Invoking a static method.");
            Console.WriteLine("-------------------------");
            T.InvokeMember("SayHello", BindingFlags.InvokeMethod | BindingFlags.Public |
                BindingFlags.Static, null, null, new object[] { });

            Console.WriteLine("------------------------");

            Customer c = new Customer();
            Console.WriteLine();
            Console.WriteLine("Invoking an instance method.");
            Console.WriteLine("----------------------------");
            c.GetType().InvokeMember("AddUp", BindingFlags.InvokeMethod, null, c, new object[] { });
            c.GetType().InvokeMember("AddUp", BindingFlags.InvokeMethod, null, c, new object[] { });

            Console.WriteLine("Properties in Customer ");
            foreach (PropertyInfo property in customerProperties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer));
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Properties in Customer2 ");
            foreach (PropertyInfo property in customerProperties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer2));
            }

            Console.WriteLine("---------------");

            foreach (var customerProperty in customerProperties)
            {
                foreach (var employeeProperty in customerProperties)
                {
                    if (customerProperty.Name == employeeProperty.Name && customerProperty.PropertyType.Name == employeeProperty.PropertyType.Name)
                    {
                        employeeProperty.SetValue(customer2, customerProperty.GetValue(customer));
                        break;
                    }
                }
            }

            Console.WriteLine("Value after changing");
            foreach (var property in customerProperties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name + " " + property.GetValue(customer2));
            }
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

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        int methodCalled = 0;

        public void AddUp()
        {
            methodCalled++;
            Console.WriteLine("AddUp Called {0} times", methodCalled);
        }

    }
}