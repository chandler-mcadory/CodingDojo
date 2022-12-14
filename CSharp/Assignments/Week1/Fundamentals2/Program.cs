Console.WriteLine("Hello, World!");


// Three Basic Arrays

// int[] numbers = new int[10];
// for(int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = i;
//     Console.WriteLine(numbers[i]);
// }

string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara"};
// for(int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// bool[] tfs = new bool[10];
// for(int i = 0; i < tfs.Length; i++)
// {
//     tfs[i] = i % 2 == 0;
//     Console.WriteLine(tfs[i]);
// }


// List of Flavors

List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("Cookie Dough");
flavors.Add("Cookies and Cream");
flavors.Add("Fudge Brownie");

// Console.WriteLine(flavors.Count);
// Console.WriteLine(flavors[2]);
// flavors.RemoveAt(2);
// Console.WriteLine(flavors.Count);


// User Dictionary

Dictionary<string,string> newPeople = new Dictionary<string,string>();
Random random = new Random();
for(int i = 0; i < names.Length; i++)
{
    int r = random.Next(flavors.Count);
    newPeople.Add(names[i], flavors[r]);
}
// kvp is convention; stands for key value pair
foreach(var kvp in newPeople)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value);
}