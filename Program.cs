Box myBox = new Box(2, 2, 2);
Ball myBall = new Ball(2);

Console.WriteLine($"The volume of myBox is {myBox.Volume()}");
Console.WriteLine($"The volume of myBall is {myBall.Volume()}");

Stack myStack = new Stack();

for (int i = 0; i < 10; i++) myStack.Push(i);

Console.WriteLine("Each item popped off myStack: ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(myStack.Pop());
}

