// MakeShapes();
MakeStacks();
// MakeUsers();
// UseRef();

void MakeShapes()
{
    Ball myBall = new Ball(2);
    Console.WriteLine($"The volume of myBall is {myBall.Volume()}");

    List<Box> overloadedBoxes = new List<Box>();
    overloadedBoxes.Add(new Box(15, 10, 10));
    overloadedBoxes.Add(new Box());
    overloadedBoxes.Add(new Box(length: 10));

    foreach (Box box in overloadedBoxes)
    {
        Console.WriteLine(box.Volume());
    }

    Box myClone = new Box(overloadedBoxes[0]);
    Console.WriteLine($"myClone vol: {myClone.Volume()} should be {overloadedBoxes[0].Volume()}");
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
    User me = new User();
    me.FirstName = "Tom";
    me.LastName = "Edward";

    User you = new User();
    you.FirstName = "Sophia";
    you.LastName = "Diggy";

    List<User> users = new List<User>() { me, you };

    User searchItem = new User();
    searchItem.FirstName = "Sophia";
    searchItem.LastName = "Diggy";

    Console.WriteLine(User.GetUserPosition(users, searchItem));
    Console.WriteLine(User.GetUserObject(users, searchItem));
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