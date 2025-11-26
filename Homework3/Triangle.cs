using System;

struct Triangle
{
    private double _base;
    private double _height;

    public double Base
    {
        get => _base;
        set
        {
            if (value <= 0)
            {
                throw new Exception("The base can not be negative or zero.");
            }
            _base = value;
        }
    }
    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
            {
                throw new Exception("The base can not be negative or zero.");
            }
            _height = value;
        }
    }
    public Triangle(double bs = 1, double ht = 1)
    {
        _base = 1;
        _height = 1;
        Base = bs;
        Height = ht;
    }
    public double Area()
    {
        return 0.5 * Base * Height;
    }
};

