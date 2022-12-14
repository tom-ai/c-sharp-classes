// MakeShapes();
// MakeStacks();
// MakeUsers(); // demos overide methods
// UseRef();
// DemoShipping(); // demos inheritance, constructors calling their base classes
// MakeMoreShapes();
// TestInterface();
// FixedStack(); // with interface
// DynamicStack(); // with interface
// StackWithInterfaceReference();
EnumDemo();


void EnumDemo()
{
    Apple ap;

    ap = Apple.GoldenDel;

    Console.WriteLine("Value of apple: " + ap);

    switch (ap)
    {
        case Apple.Jonathan:
            Console.WriteLine("Jonathan is red");
            break;
        case Apple.GoldenDel:
            Console.WriteLine("Golden delicious is yellow");
            break;
        case Apple.RedDel:
            Console.WriteLine("Red delicious is red");
            break;
        case Apple.Winesap:
            Console.WriteLine("Wine apple is red");
            break;
    }
}

public enum Apple
{
    Jonathan, GoldenDel, RedDel, Winesap
}



// void StackWithInterfaceReference()
// {
//     IIntStack myStack; // creates an interface reference variable
//     DynamicStack ds = new DynamicStack(5);
//     FixedStack fs = new FixedStack(8);

//     myStack = ds; // load dynamic stack referring it to the interface
//     for (int i = 0; i < 12; i++)
//     {
//         myStack.Push(i);
//     }

//     myStack = fs;
//     for (int i = 0; i < 8; i++)
//     {
//         myStack.Push(i);
//     }

//     myStack = ds;
//     for (int i = 0; i < 12; i++)
//     {
//         Console.WriteLine(myStack.Pop());
//     }

//     myStack = fs;
//     for (int i = 0; i < 8; i++)
//     {
//         Console.WriteLine(myStack.Pop());
//     }
// }

// void DynamicStack()
// {
//     DynamicStack myStack1 = new DynamicStack(5);
//     DynamicStack myStack2 = new DynamicStack(8);

//     // in a fixed stack, these would be over the allocated size
//     for (int i = 0; i < 12; i++) myStack1.Push(i);
//     for (int i = 0; i < 20; i++) myStack2.Push(i);

//     Console.WriteLine("Each item popped off myStack1: ");
//     for (int i = 0; i < 12; i++)
//     {
//         Console.WriteLine(myStack1.Pop());
//     }

//     Console.WriteLine("Each item popped off myStack2: ");
//     for (int i = 0; i < 20; i++)
//     {
//         Console.WriteLine(myStack2.Pop());
//     }
// }

// void FixedStack()
// {
//     FixedStack myStack1 = new FixedStack(5);
//     FixedStack myStack2 = new FixedStack(8);

//     for (int i = 0; i < 5; i++) myStack1.Push(i);
//     for (int i = 0; i < 8; i++) myStack2.Push(i);

//     Console.WriteLine("Each item popped off myStack1: ");
//     for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine(myStack1.Pop());
//     }

//     Console.WriteLine("Each item popped off myStack2: ");
//     for (int i = 0; i < 8; i++)
//     {
//         Console.WriteLine(myStack2.Pop());
//     }
// }

// void TestInterface()
// {
//     ICallback c = new Client();
//     AnotherClient ac = new AnotherClient();

//     c.Callback(42);

//     c = ac; // c now refers to AnotherClient

//     c.Callback(42); // Because only the method signature is defined, the implementation
//                     // can be different.

//     // use a nested interface reference
//     ClientA.NestedIF nesty = new ClientB();

//     if (nesty.isNotNegative(10))
//     {
//         Console.WriteLine("10 is not negative");
//     }
//     else if (nesty.isNotNegative(-10))
//     {
//         Console.WriteLine("this won't be displayed");
//     }
// }


// void MakeMoreShapes()
// {
//     Figure r = new Rectangle(9, 5); // type inferred as Figure
//     Figure t = new Triangle(10, 8); // type inferred as Figure
//     RectangleOnWheels rw = new RectangleOnWheels(9, 5);


//     // This is not allowed:
//     /*     
//     r.x = 5;
//     t.y = 5;
//     */

//     // Becuase types are inferred as the BASE class (i.e. Figure)
//     // the variables are not accessible becuase they exist only
//     // on the derived classes.

//     Figure figref;

//     /*
//     figref = f;
//     Console.WriteLine($"Area is {figref.Area()}"); // will cause runtime error
//     */

//     figref = r;
//     Console.WriteLine($"Area is {figref.Area()}");

//     figref = t;
//     Console.WriteLine($"Area is {figref.Area()}");

//     figref = rw;
//     Console.WriteLine($"Area is {figref.Area()}");
// }

// void DemoShipping()
// {
//     Shipment shipment1 = new Shipment(2, 2, 2, 1.9, 1.30);
//     Shipment shipment2 = new Shipment(4, 4, 4, 2.5, 3.48);

//     Console.WriteLine($"Volume of myShipment1 is {shipment1.Volume()}");
//     Console.WriteLine($"Weight of shipment1 is {shipment1.Weight}kg");
//     Console.WriteLine($"Shipping cost is ${shipment1.Cost}");

//     Box box = new Box();
//     BoxWeight boxWeight = new BoxWeight();
//     Shipment shipment = new Shipment();

//     List<Box> boxes = new List<Box>() { box, boxWeight, shipment };

//     foreach (Box b in boxes)
//     {
//         Console.WriteLine(b.tellMeWhoYouAre());
//     }
// }

// void MakeShapes()
// {
//     Ball myBall = new Ball(2);
//     Console.WriteLine($"The volume of myBall is {myBall.Volume()}");

//     List<Box> boxes = new List<Box>();
//     boxes.Add(new Box(15, 10, 10));
//     boxes.Add(new Box());
//     boxes.Add(new Box(length: 10));

//     foreach (Box b in boxes)
//     {
//         Console.WriteLine(b.Volume());
//     }

//     Box myClone = new Box(boxes[0]);
//     Console.WriteLine($"myClone vol: {myClone.Volume()} should be {boxes[0].Volume()}");

//     BoxWeight myWeightedBox = new BoxWeight(15, 15, 15, 450);
//     Box box = new Box();

//     double vol = myWeightedBox.Volume();
//     Console.WriteLine($"Volume of box is {box.Volume()}");
//     Console.WriteLine($"Volume of weighted box is {vol}");
//     Console.WriteLine($"Weight of weighted box is {myWeightedBox.Weight}");

//     box = myWeightedBox;

//     vol = box.Volume();
//     Console.WriteLine($"Volume of box is {box.Volume()}"); // this proves that value has passed by reference





// }

// void MakeStacks()
// {
//     Stack myStack1 = new Stack(10);
//     Stack myStack2 = new Stack(10);

//     for (int i = 0; i < 5; i++) myStack1.Push(i);
//     for (int i = 5; i < 10; i++) myStack2.Push(i);

//     Console.WriteLine("Each item popped off myStack1: ");
//     for (int i = 0; i < 5; i++)
//     {
//         Console.WriteLine(myStack1.Pop());
//     }

//     Console.WriteLine("Each item popped off myStack2: ");
//     for (int i = 5; i < 10; i++)
//     {
//         Console.WriteLine(myStack2.Pop());
//     }
// }

// void MakeUsers()
// {
//     Student me = new Student("Tommy", "Edward");
//     Teacher you = new Teacher("Sophia", "Diggy");
//     User other = new User("John", "Smith");
//     ITalk them = new Student("Ali", "Fab"); // implements interface

//     List<User> users = new List<User>() { me, you, other };

//     foreach (User u in users)
//     {
//         u.sayHello(); // implements derived versions of SayHello()
//     }
// }

// void UseRef()
// {
//     // with ref, the value of x will increase
//     // without ref, the i is only know within the scope of Test
//     // and therefore x remains untouched

//     int x = 50;
//     Test(ref x);
//     Console.WriteLine(x);

//     void Test(ref int i)
//     {
//         i++;
//     }

// }


