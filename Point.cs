﻿

class Point
{
    private double x, y;
    public double X {  
        get { return x; } 
        set { x = value; } 
    }
    public double Y { 
        get { return y; }
        set {  y = value; } 
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

}
