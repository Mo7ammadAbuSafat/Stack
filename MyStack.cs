﻿namespace Stack;

public class Stack<T>
{
    class Node
    {
        public Node next;
        public T val;

        public Node(Node e, T val)
        {
            this.next = e;
            this.val = val;
        }

    }
    private Node top;
    private int size;

    public void Push(T val)
    {
        top = new Node(top, val);
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
    public void Print()
    {
        if (size == 0)
            Console.WriteLine("the stack is empty");
        else
        {
            Node current = top;
            string s = "{ ";
            while (current != null)
            {
                s += (current.val + ", ");
                current = current.next;
            }
            Console.WriteLine(s + "}");
        }

    }
    public void Clear()
    {
        top = null;
        size = 0;
    }

}
