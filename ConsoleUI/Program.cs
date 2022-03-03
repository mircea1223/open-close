using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Mircea", LastName = "Precup" },
                new ManagerModel { FirstName = "Mihnea", LastName = "Stefan" },
                new ExecutiveModel { FirstName = "Andreea", LastName = "Iovancea" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsProgrammer: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
