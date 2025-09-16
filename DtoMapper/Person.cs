namespace DtoMapper;

public class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("홍길동", 10);
        var person2 = new Person("홍길동", 10);
        
        Console.WriteLine(person1.Equals(person2));
    }
}

record Person(string Name, int Age);