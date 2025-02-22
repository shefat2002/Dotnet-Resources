public delegate void del(string mesg);
public class AnonymousDelegate
{
    public static void Main()
    {
        del message= delegate (string mesg)
        {
            Console.WriteLine(mesg);
        };
        message("Hello, This is an Anonymous Delegate!");
    }
}