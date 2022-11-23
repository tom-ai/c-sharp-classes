// MakeShapes();
// MakeStacks();
// MakeUsers(); // demos overide methods
// UseRef();
// DemoShipping(); // demos inheritance, constructors calling their base classes
MakeMoreShapes();

void MakeMoreShapes()
{
    Figure f = new Figure(10, 10);
    Rectangle r = new Rectangle(9, 5);
    Triangle t = new Triangle(10, 8);

    List<Figure> figures = new List<Figure>();
    figures.Add(f);
    figures.Add(r);
    figures.Add(t);

    // loop through with foreach like before

    // or...

    // use a base class reference with systematic approach

    Figure figref;

    figref = f;
    Console.WriteLine($"Area is {f.Area()}");

    figref = r;
    Console.WriteLine($"Area is {r.Area()}");

    figref = t;
    Console.WriteLine($"Area is {t.Area()}");

}

void DemoShipping()
{
    Shipment shipment1 = new Shipment(2, 2, 2, 1.9, 1.30);
    Shipment shipment2 = new Shipment(4, 4, 4, 2.5, 3.48);

    Console.WriteLine($"Volume of myShipment1 is {shipment1.Volume()}");
    Console.WriteLine($"Weight of shipment1 is {shipment1.Weight}kg");
    Console.WriteLine($"Shipping cost is ${shipment1.Cost}");

    Box box = new Box();
    BoxWeight boxWeight = new BoxWeight();
    Shipment shipment = new Shipment();

    List<Box> boxes = new List<Box>() { box, boxWeight, shipment };

    foreach (Box b in boxes)
    {
        Console.WriteLine(b.tellMeWhoYouAre());
    }
}

void MakeShapes()
{
    Ball myBall = new Ball(2);
    Console.WriteLine($"The volume of myBall is {myBall.Volume()}");

    List<Box> boxes = new List<Box>();
    boxes.Add(new Box(15, 10, 10));
    boxes.Add(new Box());
    boxes.Add(new Box(length: 10));

    foreach (Box b in boxes)
    {
        Console.WriteLine(b.Volume());
    }

    Box myClone = new Box(boxes[0]);
    Console.WriteLine($"myClone vol: {myClone.Volume()} should be {boxes[0].Volume()}");

    BoxWeight myWeightedBox = new BoxWeight(15, 15, 15, 450);
    Box box = new Box();

    double vol = myWeightedBox.Volume();
    Console.WriteLine($"Volume of box is {box.Volume()}");
    Console.WriteLine($"Volume of weighted box is {vol}");
    Console.WriteLine($"Weight of weighted box is {myWeightedBox.Weight}");

    box = myWeightedBox;

    vol = box.Volume();
    Console.WriteLine($"Volume of box is {box.Volume()}"); // this proves that value has passed by reference





}

void MakeStacks()
{
    Stack myStack1 = new Stack(10);
    Stack myStack2 = new Stack(10);

    for (int i = 0; i < 5; i++) myStack1.Push(i);
    for (int i = 5; i < 10; i++) myStack2.Push(i);

    Console.WriteLine("Each item popped off myStack1: ");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(myStack1.Pop());
    }

    Console.WriteLine("Each item popped off myStack2: ");
    for (int i = 5; i < 10; i++)
    {
        Console.WriteLine(myStack2.Pop());
    }
}

void MakeUsers()
{
    Student me = new Student("Tommy", "Edward");
    Teacher you = new Teacher("Sophia", "Diggy");
    User other = new User("John", "Smith");
    ITalk them = new Student("Ali", "Fab"); // implements interface

    List<User> users = new List<User>() { me, you, other };

    foreach (User u in users)
    {
        u.sayHello(); // implements derived versions of SayHello()
    }
}

void UseRef()
{
    // with ref, the value of x will increase
    // without ref, the i is only know within the scope of Test
    // and therefore x remains untouched

    int x = 50;
    Test(ref x);
    Console.WriteLine(x);

    void Test(ref int i)
    {
        i++;
    }

}


