using System;

public abstract class Shape {
    protected double m_SideLength;
    protected double m_NumberOfSides;
    public Shape (double inSideLength, double inNumberOfSides) {
        m_SideLength = inSideLength;
        m_NumberOfSides = inNumberOfSides;
    }
    public virtual double GetPerimeter () {
        return m_NumberOfSides * m_SideLength;
    }
    public abstract double Area { get; }
}

public class Circle : Shape {
    public Circle (double inSideLength) : base (inSideLength, 0) { }

    public override double Area => 4;

    public override double GetPerimeter () {
        return 2 * 3.142 * m_SideLength;
    }

}