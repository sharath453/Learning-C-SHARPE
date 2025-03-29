using System;
class newclass
{

    static void Main()
    {
        outerclass outer=new outerclass("MARUTHI",234,"Mumbai",6);
        outer.cars();

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

    public void cars()
    {
        Console.WriteLine("car_name : "+ car_name);
        Console.WriteLine("car_number : "+ car_number);
        Console.WriteLine("car_place : "+ car_place);
        Console.WriteLine("Total_capacity : "+ Total_capacity);

    }
}