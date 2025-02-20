//enum is a value type data type. It is used to declare a list of named integer constants.

internal class Program
{
    // Enum declaration
    enum Language
    {
        PL,
        DE
    }
    static void Main(string[] args)
    {
        
        Language language = Language.PL;

        var ans = language switch{
            Language.PL => "Polish",
            Language.DE => "German",
        };

        Console.WriteLine(ans);
        // switch(language)
        // {
            
        //     case Language.PL:
        //         Console.WriteLine("Polish");
        //         break;
        //     case Language.DE:
        //         Console.WriteLine("German");    
        //         break;
        //     default:
        //         Console.WriteLine("Engilish");
        //         break;
        // }
    }
}