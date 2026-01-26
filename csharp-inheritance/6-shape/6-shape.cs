using System;

class Shape
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    /// <summary>
    /// 
    /// </summary>
    private int width;

    /// <summary>
    /// 
    /// </summary>
    private int height;

    /// <summary>
    /// 
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }

        set
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

}