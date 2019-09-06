using System.Collections.Generic;

namespace aula06CrudPeople.Models
{
    public class PersonRepository
    {
         public static List<Person> people = new List<Person>();
    
        public PersonRepository()
        {           
        }

        public void Create(Person person)
        {
            people.Add(person);
        }
        public List<Person> GetAll()
        {
            return people;
        }
        
        public Person GetById(int id)
        {
            return people.Find(i=>i.id == id);
        }
        public void Delete(int id)
        {
            people.Remove(GetById(id));
        }

        public void Update(Person person)
        {
            var i = people.FindIndex(x=>x.id == person.id);
            people[i].name = person.name;
            people[i].address = person.address;
        }

    }
}