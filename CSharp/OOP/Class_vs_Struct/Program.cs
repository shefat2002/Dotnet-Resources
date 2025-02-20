//Class
public class Person{
    public string? name{get;set;}
    public int age {get;set;}
    public Person(string Name, int Age){
        name = Name;
        age = Age;
        // Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}


//Struct
public struct Person_{
    public string? name{get;set;}
    public int age {get;set;}
    public Person_(string Name, int Age){
        name = Name;
        age = Age;
        // Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Program{
    static void Main(string[] args){
        //#class
        Console.WriteLine("Class: ");
        Person person1 = new("Rahim", 20);
        Console.WriteLine($"Person 1 Name: {person1.name}, Age: {person1.age}");

        Person person2 = person1; // Copy reference of person1

        person2.name = "Karim";
        person2.age = 22;

        Console.WriteLine($"Person 1 Name: {person1.name}, Age: {person1.age}");
        Console.WriteLine($"Person 2 Name: {person2.name}, Age: {person2.age}"); //same output



        //#struct
        Console.WriteLine("Struct: ");
        Person_ person1_ = new("Rahim", 20);
        Console.WriteLine($"Person 1 Name: {person1_.name}, Age: {person1_.age}");

        Person_ person2_ = person1_; // Copy only value of person1

        person2_.name = "Karim"; 
        person2_.age = 22;

        Console.WriteLine($"Person 1 Name: {person1_.name}, Age: {person1_.age}");
        Console.WriteLine($"Person 2 Name: {person2_.name}, Age: {person2_.age}"); //Different output
    

    }
}
