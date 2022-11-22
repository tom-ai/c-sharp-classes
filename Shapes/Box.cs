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
    
    public Box()
    {
        Width = -1;
        Height = -1;
        Depth = -1;
    }

    public Box(double length)
    {
        Width = Height = Depth = length;
    }
    public double Volume()
    {
        return Width * Depth * Height;
    }
}