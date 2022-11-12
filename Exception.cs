namespace Exception
{
    public class StackEmptyException : ArgumentOutOfRangeException
    {
        public StackEmptyException() : base("the stack is empty")
        {
        }

    }
}
