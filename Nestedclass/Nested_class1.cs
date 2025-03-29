using System;

class Nested
{
    static void Main()
    {
        
        Mynewclass.Innerclass.myinnerclass();
        Mynewclass.csk();
        
    }
}

class Mynewclass
{
    public class Innerclass
    {
        public static void myinnerclass()
        {
            Console.WriteLine("hi i am method inside thee myinnerclass");
        }
    }


    public static void csk(){
        Console.WriteLine("CSK Won the match");
    }
}


//by default the Nested class and method will be private so we have to make it public.

