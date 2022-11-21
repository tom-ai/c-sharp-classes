class Box
{
    private double width;
    private double height;
    private double depth;

    public Box(double width, double height, double depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
    public double Volume()
    {
        return width * depth * height;
    }
}