class Stack
{
    private int[] stack;
    private int tos;

    public Stack(int size)
    {
        stack = new int[size];
        tos = -1;
    }

    public void Push(int item)
    {
        if (tos == stack.Count() - 1)
        {
            Console.WriteLine("Stack is full.");
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