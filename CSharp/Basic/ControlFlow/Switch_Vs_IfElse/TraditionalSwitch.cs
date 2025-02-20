public class TraditionalSwitch{
    public int day{get;set;}

    public string dayName;
    public void GetDayName(){
        switch (day)
        {
            case 1:
            dayName = "Saturday";
            break;
            case 2:
            dayName = "Sunday";
            break;
            case 3:
            dayName = "Monday";
            break;
            default:
            dayName = "Others day";
            break;
        }
        
        Console.WriteLine(dayName);
    }
}




internal class Program
{
    static void Main(string[] args)
    {
        TraditionalSwitch weekDay = new();
        weekDay.day = 1;
        weekDay.GetDayName();
    }
}
