using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMembers
{
    internal class Family
    {
        
       
        public void AddMembers(int count, List<Person> list )
        {
           
            
            for (int i = 0; i < count; i++)
            {
               Person person = new Person();
               person.Name = Console.ReadLine();
               person.Age = int.Parse(Console.ReadLine());
               list.Add(person);
            }
        }
        public void PrintMembers(List<Person>list)
        {
            list = list.OrderBy(x => x.Name).ToList();
            list.ForEach(x => x.Print());
        }
        
        public void Statistic(int count,List<Person> list)
        {
            
            List<Person>adults = list.Where(x => x.Age > 30).ToList();
            Console.WriteLine("Age > 30 : ");
            adults = adults.OrderBy(x => x.Name).ToList();
            adults.ForEach(x => x.Print());
            
            
        }
       
     
    }
}
