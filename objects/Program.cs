using System;
class Mycode{
    static void Main()
    {
        Console.WriteLine("Hi i am an main class");

        Human h=new Human();
        h.name="Sharath";
        h.age=21;
        h.college = "Alvas Institute of Engienering";

        h.innermethod();
        Console.WriteLine("-------------------------------");

        Human human2=new Human();
        human2.name="sony";
        human2.age=67;
        human2.innermethod();
    }
}


class Human
{

    public String name;
    public int age;
    public String college;

    public void innermethod()
    {
        Console.WriteLine($"Hi i am {name}");
        Console.WriteLine($"Hi i am {age}");
        
    }

}