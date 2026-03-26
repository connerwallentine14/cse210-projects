class Circle : RoundShape
{
    protected double _radius;

    public void SetRadius (double r) {_radies = r;}

    public override double Area() { return Math.PI * _radius * _radius; } 
}
