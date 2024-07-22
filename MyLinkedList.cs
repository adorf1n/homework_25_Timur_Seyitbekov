using System;

public class MyLinkedList<T>
{
    private MyNode<T> head;
    private MyNode<T> tail;
    private int count;

    public int Count => count;
    public MyNode<T> First => head;
    public MyNode<T> Last => tail;

    public MyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public MyNode<T> Add(T element)
    {
        MyNode<T> newNode = new MyNode<T>(element);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        count++;
        return newNode;
    }

    public MyNode<T> Find(T value)
    {
        MyNode<T> current = head;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }
}
