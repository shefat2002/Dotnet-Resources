using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string ans;
        int x = 0;
        // for(int i=1;i<=x;i++)
        // {
        //     Benchmark(i);
        // }
        Benchmark(x);
        
    }

    static void Benchmark(int x)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        string s =IfElse(x);
        // string s =SwitchCase(x);
        // Console.WriteLine(s);

        stopwatch.Stop();

        double elapsedNanoseconds = stopwatch.ElapsedTicks * (1_000_000_000.0 / Stopwatch.Frequency);

        Console.WriteLine($"Input Size: {x}");
        Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Time in Nanoseconds: {elapsedNanoseconds:F3} ns\n");
    }
    static string IfElse(int x){
        string ans;
        if(x==1) ans = "One";
        else if(x==2) ans = "Two";
        else if(x==3) ans = "Three";
        else if(x==4) ans = "Four";
        else if(x==5) ans = "Five";
        else if(x==6) ans = "Six";
        else if(x==7) ans = "Seven";
        else if(x==8) ans = "Eight";
        else if(x==9) ans = "Nine";
        else if(x==10) ans = "Ten";
        else if(x==11) ans = "Eleven";
        else if(x==12) ans = "Twelve";
        else if(x==13) ans = "Thirteen";
        else if(x==14) ans = "Fourteen";
        else if(x==15) ans = "Fifteen";
        else if(x==16) ans = "Sixteen";
        else if(x==17) ans = "Seventeen";
        else if(x==18) ans = "Eighteen";
        else if(x==19) ans = "Nineteen";
        else if(x==20) ans = "Twenty";
        else if(x==21) ans = "Twenty One";
        else if(x==22) ans = "Twenty Two";
        else if(x==23) ans = "Twenty Three";
        else if(x==24) ans = "Twenty Four";
        else if(x==25) ans = "Twenty Five";
        else if(x==26) ans = "Twenty Six";
        else if(x==27) ans = "Twenty Seven";
        else if(x==28) ans = "Twenty Eight";
        else if(x==29) ans = "Twenty Nine";
        else if(x==30) ans = "Thirty";
        else if(x==31) ans = "Thirty One";
        else if(x==32) ans = "Thirty Two";
        else if(x==33) ans = "Thirty Three";
        else if(x==34) ans = "Thirty Four";
        else if(x==35) ans = "Thirty Five";
        else if(x==36) ans = "Thirty Six";
        else if(x==37) ans = "Thirty Seven";
        else if(x==38) ans = "Thirty Eight";
        else if(x==39) ans = "Thirty Nine";
        else if(x==40) ans = "Forty";
        else if(x==41) ans = "Forty One";
        else if(x==42) ans = "Forty Two";
        else if(x==43) ans = "Forty Three";
        else if(x==44) ans = "Forty Four";
        else if(x==45) ans = "Forty Five";
        else if(x==46) ans = "Forty Six";
        else if(x==47) ans = "Forty Seven";
        else if(x==48) ans = "Forty Eight";
        else if(x==49) ans = "Forty Nine";
        else if(x==50) ans = "Fifty";
        else if(x==51) ans = "Fifty One";
        else if(x==52) ans = "Fifty Two";
        else if(x==53) ans = "Fifty Three";
        else if(x==54) ans = "Fifty Four";
        else if(x==55) ans = "Fifty Five";
        else if(x==56) ans = "Fifty Six";
        else if(x==57) ans = "Fifty Seven";
        else if(x==58) ans = "Fifty Eight";
        else if(x==59) ans = "Fifty Nine";
        else if(x==60) ans = "Sixty";
        else ans = "Invalid Input";
        return ans;
    }
    static string SwitchCase(int x){
        string ans;
        switch(x){
            case 1: ans = "One"; break;
            case 2: ans = "Two"; break;
            case 3: ans = "Three"; break;
            case 4: ans = "Four"; break;
            case 5: ans = "Five"; break;
            case 6: ans = "Six"; break;
            case 7: ans = "Seven"; break;
            case 8: ans = "Eight"; break;
            case 9: ans = "Nine"; break;
            case 10: ans = "Ten"; break;
            case 11: ans = "Eleven"; break;
            case 12: ans = "Twelve"; break;
            case 13: ans = "Thirteen"; break;
            case 14: ans = "Fourteen"; break;
            case 15: ans = "Fifteen"; break;
            case 16: ans = "Sixteen"; break;
            case 17: ans = "Seventeen"; break;
            case 18: ans = "Eighteen"; break;
            case 19: ans = "Nineteen"; break;
            case 20: ans = "Twenty"; break;
            case 21: ans = "Twenty One"; break;
            case 22: ans = "Twenty Two"; break;
            case 23: ans = "Twenty Three"; break;
            case 24: ans = "Twenty Four"; break;
            case 25: ans = "Twenty Five"; break;
            case 26: ans = "Twenty Six"; break;
            case 27: ans = "Twenty Seven"; break;
            case 28: ans = "Twenty Eight"; break;
            case 29: ans = "Twenty Nine"; break;
            case 30: ans = "Thirty"; break;
            case 31: ans = "Thirty One"; break;
            case 32: ans = "Thirty Two"; break;
            case 33: ans = "Thirty Three"; break;
            case 34: ans = "Thirty Four"; break;
            case 35: ans = "Thirty Five"; break;
            case 36: ans = "Thirty Six"; break;
            case 37: ans = "Thirty Seven"; break;
            case 38: ans = "Thirty Eight"; break;
            case 39: ans = "Thirty Nine"; break;
            case 40: ans = "Forty"; break;
            case 41: ans = "Forty One"; break;
            case 42: ans = "Forty Two"; break;
            case 43: ans = "Forty Three"; break;
            case 44: ans = "Forty Four"; break;
            case 45: ans = "Forty Five"; break;
            case 46: ans = "Forty Six"; break;
            case 47: ans = "Forty Seven"; break;
            case 48: ans = "Forty Eight"; break;
            case 49: ans = "Forty Nine"; break;
            case 50: ans = "Fifty"; break;
            case 51: ans = "Fifty One"; break;
            case 52: ans = "Fifty Two"; break;
            case 53: ans = "Fifty Three"; break;
            case 54: ans = "Fifty Four"; break;
            case 55: ans = "Fifty Five"; break;
            case 56: ans = "Fifty Six"; break;
            case 57: ans = "Fifty Seven"; break;
            case 58: ans = "Fifty Eight"; break;
            case 59: ans = "Fifty Nine"; break;
            case 60: ans = "Sixty"; break;
            default: ans = "Invalid Input"; break;
        }
        return ans;
    }

}
