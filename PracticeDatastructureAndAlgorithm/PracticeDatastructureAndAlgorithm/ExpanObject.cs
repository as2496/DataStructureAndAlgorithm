using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PracticeDatastructureAndAlgorithm
{
    public class ExpanObject
    {
        
        public ExpanObject()
        {
        }
        public static void createDynamicObj()
        {
            dynamic employee, manager;
            employee = new ExpandoObject();
            employee.Name = "John Smith";
            employee.Age = 33;

            manager = new ExpandoObject();
            manager.Name = "Allison Brown";
            manager.Age = 42;
            manager.TeamSize = 10;

            WriteObject(manager);
            WriteObject(employee);
        }

        private static void WriteObject(dynamic obj)
        {
            //Console.WriteLine("{0} is {1} years old.",
            //              person.Name, person.Age);

            foreach (var property in (IDictionary<String, Object>)obj)
            {
                Console.WriteLine(property.Key + ": " + property.Value);
            }
        }
    }
}
