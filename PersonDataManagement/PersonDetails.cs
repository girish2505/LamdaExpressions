using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    class PersonDetails
    {
        List<Person> people = new List<Person>();
        public static void AddDetails(List<Person> people)
        {
            people.Add(new Person("1", "Girish", "Nellore", 21));
            people.Add(new Person("2", "sasi", "Chennai", 17));
            people.Add(new Person("3", "gowtham", "Newjersy", 60));
            people.Add(new Person("4", "nivas", "bangalore", 65));
            foreach (Person i in people)
            {
                Console.WriteLine("SSN :{0} ,Name :{1} ,Address :{2},Age :{3} .", i.SSN, i.Name, i.Address, i.Age);
            }
        }
        public static void RetrieveAge(List<Person> people)
        {
            var ageResult = people.FindAll(a => a.Age < 60).OrderBy(b => b.Age).Take(2).ToList();
            Display(ageResult);
        }
        public static void RetriveTeenage(List<Person> people)
        {
            var teenageResult = people.FindAll(a => a.Age > 13 && a.Age < 19);
            Display(teenageResult);
        }
        public static void Average(List<Person> people)
        {
            double average = people.Average(a => a.Age);
            Console.WriteLine("Average age value is : {0} ", average);
        }
        public static void SearchByName(List<Person> people,string Name)
        {
            var person = people.Find(a => a.Name.Equals(Name));
            if (person!=null)
            {
                Console.WriteLine("SSN :{0} ,Name :{1} ,Address :{2},Age :{3} .", person.SSN, person.Name, person.Address, person.Age);
            }
            else
            {
                Console.WriteLine("person not found");
            }
        }
        public static void Display(List<Person> people)
        {
            foreach (Person i in people)
            {
                Console.WriteLine("SSN :{0} ,Name :{1} ,Address :{2},Age :{3} .", i.SSN, i.Name, i.Address, i.Age);
            }
        }
    }
}
