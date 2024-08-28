using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize two Employee objects
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

            // Compare the two Employee objects using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The Employees are the same.");
            }
            else
            {
                Console.WriteLine("The Employees are different.");
            }

            Console.ReadLine();
        }
    }
}
