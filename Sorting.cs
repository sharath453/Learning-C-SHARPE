using System;
class HelloWorld {
  static void Main() {
    
    /*
    string[] cars={"cars", "bikes", "mustang"};
    Array.Sort(cars);
    foreach(String car in cars)
    {
        Console.WriteLine(car);
    }
    */
    
    
    Console.WriteLine("enter the N value");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] integers = new int[n];
    
    Console.WriteLine("Enter the array elements !");
    
    for(int i=0;i<integers.Length; i++)
    {
        integers[i]=Convert.ToInt32(Console.ReadLine());
    }
    
    Array.Sort(integers);
    
    Console.WriteLine("sorted Array is below");
    foreach(int i in integers)
    {
        Console.Write(i+ " ");
    }
  }
}