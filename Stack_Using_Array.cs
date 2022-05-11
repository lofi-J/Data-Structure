using System;

public class StackUsingArray
{
    object[] stack = new object[20];
    private int top = -1;

    public void Push(object data)
    {
        if (top == stack.Length - 1)
            throw new InvalidOperationException();
            //ResizeStack(); //throw or Resizing
                
        stack[++top] = data;
    }

    public object Pop()
    {
        if (this.IsEmpty)
            throw new ApplicationException("Empty");

        return stack[top--];
    }

    public object Peek()
    {
        if (this.IsEmpty)
            throw new ApplicationException("Empty");
        else
            return stack[top];
    }

    public bool IsEmpty
    {
        get { return top == -1; }
    }

}