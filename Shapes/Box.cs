public class Box
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }

    public Box(Box o)
    {
        Width = o.Width;
        Height = o.Height;
        Depth = o.Depth;
    }

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

    public virtual string tellMeWhoYouAre()
    {
        return "I am a BOX";
    }
}

public class BoxWeight : Box
{
    public double Weight { get; set; }

    public BoxWeight(BoxWeight o) : base(o)
    {
        Weight = o.Weight;
    }

    public BoxWeight(double width, double height, double depth, double weight) : base(width, height, depth)
    {
        Weight = weight;
    }

    public BoxWeight() : base()
    {
        Weight = -1;
    }

    public BoxWeight(double length, double m) : base(length)
    {
        Weight = m;
    }

    public override string tellMeWhoYouAre()
    {
        return "I am a BOX WEIGHT";
    }
}

public class Shipment : BoxWeight
{
    public double Cost { get; set; }

    public Shipment(Shipment o) : base(o)
    {
        Cost = o.Cost;
    }
    public Shipment(double width, double height, double depth, double weight, double cost) : base(width, height, depth, weight)
    {
        Cost = cost;
    }

    public Shipment() : base()
    {
        Cost = -1;
    }

    public Shipment(double length, double m, double cost) : base(length, m)
    {
        Cost = cost;
    }

    public override string tellMeWhoYouAre()
    {
        return "I am a SHIPMENT";
    }
}
