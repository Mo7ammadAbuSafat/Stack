using static Stack.Stack<int>;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(2);
            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch(StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                stack.Print();
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


