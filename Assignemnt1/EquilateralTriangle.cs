public class EquilateralTriangle : Shape {
    public EquilateralTriangle (double inSideLength) : base (inSideLength, 3) {

    }

    public override double Area {
        get {
            return Math.Sqrt (m_NumberOfSides) / 4 * m_SideLength * m_SideLength;
        }
    }
}