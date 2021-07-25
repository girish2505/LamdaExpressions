using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PersonDataManagement");
            List<Person> people = new List<Person>();
            Console.WriteLine("Person Details");
            Console.WriteLine("-------------------------------");
            PersonDetails.AddDetails(people);
            Console.WriteLine("Retrieve Top two people who's age is >60");
            Console.WriteLine("-------------------------------");
            PersonDetails.RetrieveAge(people);
            Console.WriteLine("Retrieve teenage Records");
            Console.WriteLine("-------------------------------");
            PersonDetails.RetriveTeenage(people);
        }
    }
}
