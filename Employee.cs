using System;

namespace OperatorsAssignment
{
    class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (Object.ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If one is null, but not both, return false
            if (((object)emp1 == null) || ((object)emp2 == null))
            {
                return false;
            }

            // Return true if the fields match
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator to compare Employee objects by Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() to satisfy compiler warnings
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee emp = (Employee)obj;
            return Id == emp.Id;
        }

        // Override GetHashCode() to satisfy compiler warnings
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
