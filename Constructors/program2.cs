using System;
class newclass{
    static void Main()
    {
        outerclass outer=new outerclass("MARUTHI",234,"Mumbai",6);
        outerclass.cars(outer);
    // when we have to access the static method we shhould pass the object into the ==> class_name.method_name(object_name)
    }
}


class outerclass{

    String car_name;
    int car_number;
    String car_place;
    int Total_capacity;

    public outerclass(String car_name, int car_number, String car_place, int Total_capacity)
    {
        this.car_name = car_name;
        this.car_number = car_number;
        this.car_place = car_place;
        this.Total_capacity = Total_capacity;  
    }


    //that parameters which we passed will be recieved here
    // inside that methdo we should have that constructor name as referenec
    public static void cars(outerclass obj)
    {
        Console.WriteLine("car_name : "+ obj.car_name);
        Console.WriteLine("car_number : "+ obj.car_number);
        Console.WriteLine("car_place : "+ obj.car_place);
        Console.WriteLine("Total_capacity : "+ obj.Total_capacity);

    }
}