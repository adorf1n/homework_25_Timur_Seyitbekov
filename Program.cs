using System;

class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("First: " + list.First.Value);
        Console.WriteLine("Last: " + list.Last.Value);

        MyNode<int> node = list.Find(5);
        if (node != null)
        {
            Console.WriteLine("Found: " + node.Value);
        }
        else
        {
            Console.WriteLine("Value not found");
        }
    }
}
