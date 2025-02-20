internal class NewSwitch
{
    public int age{get;set;}
    public string category;

    public void GetAgeCategory(){
        category = age switch
        {
            <=12 => "Child",
            <19 => "Teen",
            <30 => "Young Adult",
            <60 => "Adult",
            _ => "Senior"
        };
        Console.WriteLine($"Age: {age} = {category}");
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        NewSwitch person = new();
        person.age = 12;
        person.GetAgeCategory();

        person.age = 25;
        person.GetAgeCategory();
    }
}