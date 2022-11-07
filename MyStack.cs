namespace Stack;

public class MyStack<T>
{
    class Entity
    {
        public Entity next;
        public T val;

        public Entity(Entity e, T val)
        {
            this.next = e;
            this.val = val;
        }

    }
    private Entity top;
    private int size;

    public void Push(T val)
    {
        top = new Entity(top, val);
        size++;
    }
    public void Peek()
    {
        if (size == 0)
        {
            throw new ArgumentOutOfRangeException("stack is empty");
        }
        Console.WriteLine(top.val);
    }
    public T Pop()
    {
        if (size == 0)
        {
            throw new ArgumentOutOfRangeException("the stack is empty");
        }
        T val = top.val;
        top = top.next;
        size--;
        return val;
    }

}
