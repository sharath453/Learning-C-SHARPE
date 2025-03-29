using System;
class Mainclass
{
    static void Main()
    {
        //Outerclass.outermethod();
        //Outerclass.Innerclass.innermethod();

        // the methos u r accessinng is non static we have to create a class

        /*
        Outerclass.Innerclass nam = new Outerclass.Innerclass();
        nam.innermethod();
        */

        Outerclass out1=new Outerclass();
        out1.outermethod();

    }
}


class Outerclass
{

    public void outermethod()
    {
        Console.WriteLine("Hlo i am outer class");
    }

    public class Innerclass
    {
        public void innermethod()
        {
            Console.WriteLine("hi i a intter method");
        }
    }
}