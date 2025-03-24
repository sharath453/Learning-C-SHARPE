public class RegularPentagon : Shape {

    public int A { get; }
    public RegularPentagon (double inSideLength) : base (inSideLength, 5) {

    }
    public override double Area {
        get {
            return (Math.Sqrt (m_NumberOfSides * (m_NumberOfSides + 2 * (Math.Sqrt (m_NumberOfSides)))) * m_SideLength * m_SideLength) / 4;
        }
    }
}