using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMembers
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person()
        {
            this.Name = "Pesho";
            this.Age = 14;
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name,int age) : this(name)
        {
            this.Age = age;
        }
        public void Print()
        {
            Console.WriteLine(Name + " -  " + age);  
        }
    }
}
