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
            Console.WriteLine("\nRetrieve Top two people who's age is >60");
            Console.WriteLine("-------------------------------");
            PersonDetails.RetrieveAge(people);
            Console.WriteLine("\nRetrieve teenage Records");
            Console.WriteLine("-------------------------------");
            PersonDetails.RetriveTeenage(people);
            Console.WriteLine("\nCalculating average of the age");
<<<<<<< HEAD
            Console.WriteLine("-------------------------------");
=======
            Console.WriteLine("------------------------------ - ");
>>>>>>> 6.SkipRecordLessThan60
            PersonDetails.Average(people);
            Console.WriteLine("\nSearching the person by name");
            Console.WriteLine("-------------------------------");
            PersonDetails.SearchByName(people, "Girish");
            Console.WriteLine("\nskip the records who's age is less than 60");
            Console.WriteLine("-------------------------------");
            PersonDetails.SkipRecordLessThan60(people);
        }
    }
}
