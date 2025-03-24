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