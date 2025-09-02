namespace Data;

public class Employee
/*총무부 리더 홍길동(41세) 인스턴스를 직렬화하여 company.json 파일에 Json String 형태로 저장하는
프로그램을 작성하시오*/
{
    public string Name { get; }
    public int Age { get; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}