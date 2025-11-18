public class Vector
{
    private double[] arr;
    public Vector(params double[] elements)
    {
        arr = elements;
    }
    public int Size => arr.Length;
    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < arr.Length) return arr[index];
            else return 0;
        }
        set
        {
            if (index >= 0 && index < arr.Length) arr[index] = value;
        }
    }
    public static double operator *(Vector arr1, Vector arr2)
    {
        double result = 0;
        for (int i = 0; i < arr1.Size; i++)
        {
            result += arr1[i] * arr2[i];
        }
        return result;
    }
    public override string ToString()
    {
        return "[" + string.Join(", ", arr) + "]";
    }
}