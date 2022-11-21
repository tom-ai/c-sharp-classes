class Ball
{
    public double Radius { get; set; }

    public Ball(double radius)
    {
        Radius = radius;
    }

    public double Volume()
    {
        double volume = (4.0 / 3 * Math.PI * Math.Pow(Radius, 3));
        return Math.Round(volume, 2);
    }
}