public class FixedStack : IIntStack
{
    private int[] stack;
    private int tos;

    public FixedStack(int size)
    {
        stack = new int[size];
        tos = -1;
    }

    public void Push(int item)
    {
        if (tos == stack.Count())
        {
            Console.WriteLine("Stack is full");
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
            Console.WriteLine("Stack underflow");
            return 0;
        }
        else
        {
            return stack[tos--];
        }
    }
}