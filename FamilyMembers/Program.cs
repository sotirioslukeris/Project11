using FamilyMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Зад 1
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person person1 = new Person();
            person1.Age = 20;
            person1.Print();
            Person person2 = new Person("Gosho", 20);
            person2.Print();
            Person person3 = new Person("Stamat", 43);
            person3.Print();
            //Зад 2
            List<Person> familyMembers = new List<Person>(); 
            Family family = new Family();
            Console.Write("Family members count : ");
            int count = int.Parse(Console.ReadLine());
            family.AddMembers(count,familyMembers);
            family.PrintMembers(familyMembers);
            //Зад 3
            family.Statistic(count, familyMembers);
            

        }
    }
}
