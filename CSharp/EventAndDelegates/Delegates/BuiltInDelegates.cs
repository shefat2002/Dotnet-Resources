internal class BuiltInDelegates
{
    
    static void Main(string[] args)
    {
        // Action<T> Delegate
        Action<string> printMesg = mesg => Console.WriteLine(mesg);
        printMesg("Hello World");

        //Func<T, TResult> Delegate
        Func<int,int,int>mul = (a,b) => a*b;
        Console.WriteLine(mul(10,10));

        //Predicate<T> Delegate
        Predicate<int> isEven = num => num%2==0;
        Console.WriteLine(isEven(10));


    }

    


}