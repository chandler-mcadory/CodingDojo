// See https://aka.ms/new-console-template for more information

using practice;

string words = "Hello, World!";
int x = 5;
double y = x + 1.0;
long j = 1234567890123456789;
decimal z = (decimal)3.123456789;

bool tf = false;
bool any = true;
object n = null;      // c# has null values, does not have undefined values
char c = 'a';         // single quotes are 1 character, double quotes are a string of characters
char[] word = "new array".ToCharArray();
int[] numbers = new int[10];   // the array "numbers" has bee created. it is empty with 10 spaces
                               // new is a BIG keyword; new: create a space in memory for something


Person p = new Person("Rob", 167);
Person o = new Person("Chan", 165);
PersonService service = new PersonService();
Person older = service.GetHigherAge(p, o);

service.AddPerson(p);
Person persons = service.GetPersonByName("Rob");
