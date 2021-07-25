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
            people.Add(new Person("1", "Grish", "Nellore", 21));
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
        public static void Display(List<Person> people)
        {
            foreach (Person i in people)
            {
                Console.WriteLine("SSN :{0} ,Name :{1} ,Address :{2},Age :{3} .", i.SSN, i.Name, i.Address, i.Age);
            }
        }
    }
}
