public delegate int MathOperation(int x, int y);
public class DelegateWithLambda
{
    public static void Main()
    {
        MathOperation add = (x,y) => x+y;
        MathOperation sub = (x,y) => x-y;
        MathOperation mul = (x,y) => x*y;
        MathOperation div = (x,y) => x/y;

        Console.WriteLine("Sum = "+ add(10,20));    
    }
}