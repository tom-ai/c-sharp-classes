class Box
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }

    public Box(double width, double height, double depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }
    public double Volume()
    {
        return Width * Depth * Height;
    }
}