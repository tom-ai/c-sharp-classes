class Stack
{
    private int[] stack = new int[10];
    private int tos;

    public Stack()
    {
        tos = -1;
    }

    public void Push(int item)
    {
        if (tos == 9)
        {
            Console.WriteLine(tos + " " + "Stack is full.");
        }
        else
        {
            stack[++tos] = item;
        }
    }

    public int Pop()
    {
        if (tos < 0)
        {
            Console.WriteLine("Stack is empty");
            return 0;
        }
        else
        {
            return stack[tos--];
        }
    }
}