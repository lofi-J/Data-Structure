using System;

public class Dynamic_Array
{
    private object[] arr = new object[0];
    public void Add(object element)
    {
        var temp = new object[arr.Length + 1];

        for ( int i = 0; i < arr.Length; i++) //arr[] -> temp[] copy
        {
            temp[i] = arr[i];
        }
        arr = temp;

        arr[arr.Length - 1] = element; //add element
    }

    public void Peek()
    {
        foreach(object x in arr)
        {
            Console.Write(x + ", ");
        }
        Console.WriteLine("\b\b ");
    }
}
/*
Dynamic_Array myDynamicArr = new Dynamic_Array();
        myDynamicArr.Add(0);
        myDynamicArr.Add(1);
        myDynamicArr.Add(2);
        myDynamicArr.Peek();


result

0, 1, 2

 */