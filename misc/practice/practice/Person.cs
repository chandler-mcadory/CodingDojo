
namespace practice
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public int Age { get; set; }
        public Person(string name, int age) 
        {
            Name= name; 
            Age= age;
            Birth= DateTime.Now.AddYears(-1*Age);
        }
    }
}
