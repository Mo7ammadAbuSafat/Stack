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

}
