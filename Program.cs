MakeShapes();
// MakeStacks();
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