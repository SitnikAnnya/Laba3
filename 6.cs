using System.Text.RegularExpressions;
using System;

class Program
{
    public static void Main(string[] args)
    {
        string FirstStr = ("порошр дакокштр опошкда кпв");
        string SecondStr = ("првопк ргр раопда ргвда");
        string BothStr = FirstStr + " " + SecondStr;
        string FindInStr = ("да");

        int count = Regex.Matches(BothStr, FindInStr).Count;
        Console.WriteLine(count);
    }
}