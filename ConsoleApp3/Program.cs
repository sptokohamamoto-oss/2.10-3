using System;

class Program
{
    static void Main(string[] args)
    {
        int intTest = 1;

        string StringTest = "01";

        Console.WriteLine($"String{intTest}");


        int convertendInt = int.Parse(StringTest);
        int result = convertendInt + 1;

        Console.WriteLine(result);

    }

}
