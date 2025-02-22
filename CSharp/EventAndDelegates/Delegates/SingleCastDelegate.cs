public delegate void Del(string mesg);

public class SingleCastDelegate
{
    public static void Display(string mesg){
        Console.WriteLine(mesg);
    }
    static void Main()
    {
        Del message = new Del(Display);
        message("Hello");
    }
}