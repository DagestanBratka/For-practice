public class Point
{
    private int x;
    private int y;
    public Point(int x, int y   )
    {
        this.x = x;
        this.y = y;
    }
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.x - b.x, a.y - b.y);
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}