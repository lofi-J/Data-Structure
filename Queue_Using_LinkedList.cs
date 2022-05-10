using System;

public class QueueNode
{
    public object Data { get; set; }
    public QueueNode next { get; set; }
    public QueueNode(object data)
    {
        this.Data = data;
        this.next = null;
    }
}


public class QueueUsingLinkedList
{
    private QueueNode head = null;
    private QueueNode tail = null;

    public void Enqueue(object data)
    {
        if (head == tail)
        {
            head = new QueueNode(data);
            tail = head;
        }
        else
        {
            tail.next = new QueueNode(data);
            tail = tail.next;
        }
    }

    public object Dequeue()
    {
        if (head == null)
            throw new ApplicationException("Empty");

        object data = head.Data;

        if (head == tail)
        {
            head = tail = null;
        }
        else
        {
            head = head.next;
        }

        return data;
    }

}
