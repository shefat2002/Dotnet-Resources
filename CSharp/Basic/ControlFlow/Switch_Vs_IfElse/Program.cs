//Using If else

internal class AgeClassification
{
    public int age{get;set;}
    public string category;

    public void GetAgeCategory(){
        if(age <= 12){
            category = "Child";
        }
        else if(age < 19){
            category = "Teen";
        }
        else if(age <= 30){        
            category = "Young Adult";
        }
        else if(age < 60){
            category = "Adult";
        }
        else{
            category = "Senior";
        }

        Console.WriteLine($"Age: {age} = {category}");
    }

}




internal class Program
{
    static void Main(string[] args)
    {
        AgeClassification person = new();
        person.age = 12;
        person.GetAgeCategory();

        person.age = 25;
        person.GetAgeCategory();
    }
}