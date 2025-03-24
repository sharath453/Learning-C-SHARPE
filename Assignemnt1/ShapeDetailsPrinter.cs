public class ShapeDetailsPrinter {
    public static void PrintDetails (Shape inShape) {
        Console.WriteLine ("Area: {0}     Perimeter: {1}", inShape.Area, inShape.GetPerimeter ());
    }

    public static void PrintDetails (RegularPentagon inShape) {
        Console.WriteLine ("Area: {0}     Perimeter: {1}", inShape.Area, inShape.GetPerimeter ());
    }

    public static void PrintDetails (EquilateralTriangle inShape) {
        Console.WriteLine ("Area: {0}     Perimeter: {1}", inShape.Area, inShape.GetPerimeter ());
    }
}