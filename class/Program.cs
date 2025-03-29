using System;

    class program1{
        static void Main()
        {
            Console.WriteLine("hi dear sarala");
            Mycode.market();
            Myfirstcode m = new Myfirstcode();
            m.mystring1();
        }
    }

    class Myfirstcode
    {
        public void mystring1()
        {
            Console.WriteLine("hi");
        }
    }


    // class name 1st letter should be capitial 
    // a static maethod cannot be called using a object, the non static method requir a object to access the class
    // object is a blueprint of class
    // static method not requir any kind of object to access just a class_name.method_name(); is enough