MakeShapes();
MakeStacks();

void MakeShapes()
{
    Box myBox = new Box(2, 2, 2);
    Ball myBall = new Ball(2);

    List<int> widths = new List<int>() { 2, 3, 4 };
    List<int> heights = new List<int>() { 2, 3, 4 };
    List<int> depths = new List<int>() { 2, 3, 4 };

    List<Box> boxes = new List<Box>();

    for (int i = 0; i < widths.Count; i++)
    {
        Box box = new Box(widths[i], heights[i], depths[i]);
        boxes.Add(box);
    }

    foreach (Box box in boxes)
    {
        Console.WriteLine(box.Volume());
    }

    Console.WriteLine($"The volume of myBox is {myBox.Volume()}");
    Console.WriteLine($"The volume of myBall is {myBall.Volume()}");
}

void MakeStacks()
{
    Stack myStack = new Stack();

    for (int i = 0; i < 10; i++) myStack.Push(i);

    Console.WriteLine("Each item popped off myStack: ");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(myStack.Pop());
    }
}
