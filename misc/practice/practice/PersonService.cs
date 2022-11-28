
namespace practice
{
    public class PersonService
    {
        public List<Person> PersonsDatabase = new List<Person>();

        public void AddPerson(Person p)
        {
            PersonsDatabase.Add(p);
        }

        public Person GetPersonByName(string name)
        {
            return PersonsDatabase.Find(x => x.Name == name);
        }

        public Person GetHigherAge(Person person1, Person person2) 
        {
            if (person1.Age > person2.Age)
            {
                return person1;
            }
            return person2;
        }
    }
}
