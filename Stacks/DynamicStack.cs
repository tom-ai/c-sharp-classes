public class DynamicStack : IIntStack
{
    private int[] stack;
    private int tos;
    public DynamicStack(int size)
    {
        stack = new int[size];
        tos = -1;
    }

    public void Push(int item)
    {
        if (tos == stack.Count() - 1)
        {
            int[] temp = new int[stack.Count() * 2];
            for (int i = 0; i < stack.Count(); i++)
            {
                temp[i] = stack[i];
            }

            // now there's headroom in temp
            // lets assign it to the 'stack' reference and add the item
            stack = temp;
            stack[++tos] = item;
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