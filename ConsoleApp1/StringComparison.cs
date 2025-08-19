namespace ConsoleApp1;

public class StringComparison
{
    public static void Main()
    {
        string str1="hello";
        string str2="hello";
        Console.WriteLine(object.ReferenceEquals(str1,str2));
        
        string str3=new string(new char[]{'h', 'e', 'l', 'l', 'o'});
        //Console.WriteLine(str1.Equals(str3));
        Console.WriteLine(ReferenceEquals(str1,str3));

        string str4 = "hel" + "lo";
        Console.WriteLine(object.ReferenceEquals(str1,str4));

        string str5 = "hel" + GetLo();
        Console.WriteLine(object.ReferenceEquals(str1,str5));
    }

    public static string GetLo()
    {
        return "lo";
    }
    static void Instance(){}
}