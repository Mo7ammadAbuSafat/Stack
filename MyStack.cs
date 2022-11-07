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
}
