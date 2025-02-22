List<string> list= new(){
    "Rahim", "Karim","Alex","Jack","Joe", "Jabbar", "Abdulla", "Shefat","Bob", "Abc"
};

foreach (var item in list)
{
    Console.Write(item + " ");
}
Console.WriteLine();

//Uppercase All
foreach (var item in list)
{
    Console.Write(item.ToUpper() + " ");
}

Console.WriteLine();

//Add new items to list
list.Add("Cde");
list.Add("Xyz");

//Total Size
Console.WriteLine($"Total Names: {list.Count}");

//Last Element
Console.WriteLine(list[list.Count-1]);

//Searching
var toFind = "Abc";
if(list.IndexOf(toFind) !=-1){
    Console.WriteLine($"{toFind} found in list");
}

//Sorting
list.Sort();
foreach(var item in list){
    Console.Write(item + " ");
}


Console.WriteLine();