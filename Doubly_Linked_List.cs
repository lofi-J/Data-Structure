using System;

public class DoublyLinkedListNode<T>
{
    public DoublyLinkedListNode<T> Prev;
    public DoublyLinkedListNode<T> Next;
    public T data;

    public DoublyLinkedListNode(T data)
    {
        this.data = data;
        Prev = null;
        Next = null;
    }
}

public class DoublyLinkedList<T>
{
    private DoublyLinkedListNode<T> head;
    //DoublyLinkedListNode<T> tail;

    public void Add(DoublyLinkedListNode<T> newNode)
    {
        if (head == null)
            head = newNode;
        else
        {
            var current = head;
            while(current!=null && current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Prev = current;
            newNode.Next = null;
        }
    }

    public void AddAfter(DoublyLinkedListNode<T> current, DoublyLinkedListNode<T> newNode)
    {
        if (head == null || current == null || newNode == null)
            throw new InvalidOperationException();

        newNode.Next = current.Next;
        current.Next.Prev = newNode;
        current.Next = newNode;
        newNode.Prev = current;
    }

    public void Remove(DoublyLinkedListNode<T> removeNode)
    {
        if (head == null || removeNode == null)
            throw new InvalidOperationException();

        if (removeNode == head)
        {
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
        }            
        else
        {
            removeNode.Prev.Next = removeNode.Next;
            if (removeNode.Next != null)
                removeNode.Next.Prev = removeNode.Prev;
        }
        removeNode = null;        
    }

    public DoublyLinkedListNode<T> GetNode(int index)
    {
        var current = head;
        for(int i = 0; i<index && current != null; i++)
        {
            current = current.Next;
        }
        return current;
    }

    public int Count()
    {
        int count = 0;
        var current = head;
        while(current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}