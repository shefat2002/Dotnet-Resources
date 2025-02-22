internal class TraditionalSwitchWithMultipleCondition
{
    public int age{get;set;}
    public string category;
    public void GetAgeCategory(){
        switch (age)
        {
            case int n when (n >= 0 && n<=12):
            category = "Child";
            break;
            case int n when (n > 12 && n<19):
            category = "Teen";
            break;
            case int n when (n >= 19 && n<=30):
            category = "Young Adult";
            break;
            case int n when (n > 30 && n<60):
            category = "Adult";
            break;
            default:
            category = "Senior";
            break;
        }
        Console.WriteLine($"Age: {age} = {category}");
    }

}


internal class Program
{
    static void Main(string[] args)
    {
        TraditionalSwitchWithMultipleCondition person = new();
        person.age = 12;
        person.GetAgeCategory();

        person.age = 25;
        person.GetAgeCategory();
    }
}