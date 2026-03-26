using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Cylinder : CriticalHandle
{
    private double _height;

    public void SetHeight(double h) {_height = h; }
    public override double Area() 
    { 
        return 2 * Math.PI * 
    }
}