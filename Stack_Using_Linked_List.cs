using System;

class StackNode
{
    public object data { get; set; }
    public StackNode next;

    public StackNode(object data)
    {
        this.data = data;
        this.next = null;
    }
}

class StackUsingLinkedList
{    
    private StackNode top = null;

    public bool IsEmpty
    {
        get { return top == null; }
    }

    public void Push(object data)
    {
        if (top == null)
        {
            top = new StackNode(data);
        }
        else
        {
            var node = new StackNode(data);
            node.next = top;
            top = node;            
        }
    }

    public object Pop()
    {
        if (this.IsEmpty)
            throw new ApplicationException("Empty");
        else
        {
            object data = top.data;
            top = top.next;
            return data;
        }
    }

    public object Peek()
    {
        if (this.IsEmpty)
            throw new ApplicationException("Empty");

        return top.data;
    }
}