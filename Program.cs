namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Peek();
            stack.Print();
            stack.Clear();
            stack.Print();
            
        }

    }
}


