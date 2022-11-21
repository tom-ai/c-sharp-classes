class Ball
{
    private double radius;
    public Ball(double radius)
    {
        this.radius = radius;
    }

    public double Volume()
    {
        double volume = (4.0 / 3 * Math.PI * Math.Pow(radius, 3));
        return Math.Round(volume, 2);
    }
}