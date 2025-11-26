using System;

public struct Rectangle
{
    private double _width;
    private double _height;
    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Height can not be negative number or zero.");
            }
            _height = value;
        }
    }
    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
            {
                throw new Exception("Weight can not be negative number or zero.");
            }
            _height = value;
        }
    }

    public Rectangle(double width = 1, double height = 1)
    {
        _width = 1;
        _height = 1;
        Width = width;
        Height = height;
    }
    public double Area()
    {
        return Width * Height;
    }

};

