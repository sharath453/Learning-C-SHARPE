public class Square : Shape {
    public Square (double inSideLength) : base (inSideLength, 4) {

    }

    public override double Area {
        get {
            return m_SideLength * m_SideLength;
        }
    }
}