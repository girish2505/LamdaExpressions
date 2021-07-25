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
            AddDetails(people);
        }
        public static void AddDetails(List<Person> people)
        {
            people.Add(new Person("1", "Grish", "Nellore", 21));
            people.Add(new Person("2", "sasi", "Chennai", 37));
            people.Add(new Person("3", "gowtham", "Newjersy", 45));
            people.Add(new Person("4", "nivas", "bangalore", 35));
            foreach (Person i in people)
            {
                Console.WriteLine("SSN :{0} ,Name :{1} ,Address :{2},Age :{3} .", i.SSN, i.Name, i.Address, i.Age);
            }
        }
    }
}
