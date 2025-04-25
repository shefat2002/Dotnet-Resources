Dictionary<int,string> dict = new Dictionary<int, string>();
dict.Add(101,"ABC");
dict.Add(102,"ABC");
dict.Add(103,"ABC");
dict.Add(104,"ABC");


// Dictonary<int,string> dic = new();

foreach(var d in dict)
{
    Console.WriteLine($"ID: {d.Key}, Name: {d.Value}");
}