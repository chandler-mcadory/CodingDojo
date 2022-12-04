Console.WriteLine("Hello, World!");


// 1 iterate & print values

static void PrintList(List<string> MyList)
{
    for (int i = 0; i < MyList.Count; i++)
    {
        Console.WriteLine(MyList[i]);
    }
}


// 2 print sum

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        sum = sum + IntList[i];
    }
    Console.WriteLine(sum);
}


// 3 find the max

static int FindMax(List<int> IntList)
{
    int max = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }
    return max;
}


// 4 square the values

static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] = IntList[i] * IntList[i];
    }
    return IntList;
}


// 5 replace negatives w 0

static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}


// 6 print dictionary

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (var kvp in MyDictionary)
    {
        Console.WriteLine(kvp.Key);
        Console.WriteLine(kvp.Value);
    }
}


// 7 find key

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    foreach (var kvp in MyDictionary)
    {       // MyDictionary.ContainsKey(Searchterm)
        if (kvp.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}


// 8 generate a dictionary from two lists

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    var MyDictionary = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        MyDictionary.Add(Names[i], Numbers[i]);
    }
    return MyDictionary;
}