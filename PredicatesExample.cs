using System;
using System.Collections.Generic;

namespace PredicateDemo
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    public class PredicateExamples
    {
        public void RunExamples()
        {
            // 1. Basic List Setup
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 25, Department = "Tech" },
                new Employee { Name = "Bob", Age = 45, Department = "HR" },
                new Employee { Name = "Charlie", Age = 32, Department = "Tech" },
                new Employee { Name = "Diana", Age = 50, Department = "Sales" }
            };

            // ---------------------------------------------------------
            // 2. Inline Lambda Predicate
            // Usage: Quick, one-off checks.
            // ---------------------------------------------------------
            bool hasSeniorStaff = employees.Exists(e => e.Age > 60);


            // ---------------------------------------------------------
            // 3. Explicit Predicate Variable
            // Usage: Reusable logic within the same class.
            // ---------------------------------------------------------
            Predicate<Employee> isTechDept = e => e.Department == "Tech";
            Employee firstTech = employees.Find(isTechDept);


            // ---------------------------------------------------------
            // 4. Method-Based Predicate
            // Usage: Complex logic that is too long for a lambda.
            // ---------------------------------------------------------
            List<Employee> eligibleForPromotion = employees.FindAll(CheckPromotionEligibility);


            // ---------------------------------------------------------
            // 5. Predicate with List.RemoveAll
            // Usage: Mutating a list based on a condition.
            // ---------------------------------------------------------
            employees.RemoveAll(e => e.Age < 21);
        }

        /// <summary>
        /// A standalone method that matches the Predicate signature:
        /// Takes one parameter (Employee) and returns a bool.
        /// </summary>
        public static bool CheckPromotionEligibility(Employee e)
        {
            // Complex logic belongs here
            return e.Age > 30 && e.Department != "HR";
        }
    }
}