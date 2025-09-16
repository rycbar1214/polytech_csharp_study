namespace DtoMapper;

public class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("홍길동", 10);
        var person2 = new Person("홍길동", 10);
        
        Console.WriteLine(person1.Equals(person2));
        Console.WriteLine(person2.ToString());

        Animal animal = new Dog();

        switch (animal)
        {
            case Dog dog:
                Console.WriteLine(dog.ToString());
                break;
            case Cat cat:
                Console.WriteLine(cat.ToString());
                break;
            default:
                break;
        }
    }
}

record Person(string Name, int Age);

public class Animal
{
    
}

public class Dog : Animal
{
    
}
public class Cat : Animal
{
    
}