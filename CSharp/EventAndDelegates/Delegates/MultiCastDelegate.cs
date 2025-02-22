public delegate void Delegate(string mesg);

public class MultiCastDelegate
{
    public static void M1(string mesg) => Console.WriteLine("Method 1: "+ mesg);
    public static void M2(string mesg) => Console.WriteLine("Method 2: "+ mesg);
    
    static void Main()
    {
        Delegate del= M1;
        del += M2;
        del("Hello");
        del -= M2;
        del("Hello World");
    }
}