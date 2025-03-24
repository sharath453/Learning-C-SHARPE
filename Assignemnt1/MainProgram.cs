/*

CHAPTER 6: Introducing Classes and Objects
CHAPTER 8: A Closer Look at Methods and Classes
CHAPTER 11: Inheritance

Calculate and print the area and perimeters of a Square, Equilateral Triangle & Regular Pentagon.
Check out and make use of C# Properties with appropriate access specifiers.
*/

public class MainProgram {
    public static void Main (string[] args) {
        double sideLength = 6;
        Square square = new Square (sideLength);
        ShapeDetailsPrinter.PrintDetails (square);

        EquilateralTriangle equilateralTriangle = new EquilateralTriangle (sideLength);
        ShapeDetailsPrinter.PrintDetails (equilateralTriangle);

        RegularPentagon regularPentagon = new RegularPentagon (sideLength);
        ShapeDetailsPrinter.PrintDetails (regularPentagon);
    }
}