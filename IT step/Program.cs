
Box b1 = new(2, 4, 5);
Box b2=new(2, 4, 5);
Console.WriteLine(b1 <= b2);
Console.WriteLine(b2 >= b1);
Console.WriteLine(b2 == b1);
Console.WriteLine(b2 != b1);


public class Box
{
    private double _height;
    private double _width;
    private double _length;

    public double Height { get { return _height; } set { _height = value; } }
    public double Width { get { return _width; } set { _width = value; } }
    public double Length { get { return _length; } set { _length = value; } }

    public Box() { }
    public Box(double height, double width, double length)
    {
        Height = height;
        Width = width;
        Length = length;
        Height = height;
        Width = width;
        Length = length;
    }

    public static  bool operator>= (Box b1, Box b2)
    {
        if(b1.Height < b2.Height)
        {
            return false;
        }
        if (b1.Width < b2.Width)
        {
            return false;
        }
        if (b1.Length < b2.Length)
        {
            return false;
        }

        return true;
    }

    public static bool operator <=(Box b1, Box b2)
    {
        if (b1.Height > b2.Height)
        {
            return false;
        }
        if (b1.Width > b2.Width)
        {
            return false;
        }
        if (b1.Length > b2.Length)
        {
            return false;
        }

        return true;
    }

    public static bool operator ==(Box b1, Box b2)
    {
        if (b1.Height != b2.Height)
        {
            return false;
        }
        if (b1.Width != b2.Width)
        {
            return false;
        }
        if (b1.Length != b2.Length)
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(Box b1, Box b2)
    {
        if (b1.Height == b2.Height)
        {
            return false;
        }
        if (b1.Width == b2.Width)
        {
            return false;
        }
        if (b1.Length == b2.Length)
        {
            return false;
        }

        return true;
    }
}
