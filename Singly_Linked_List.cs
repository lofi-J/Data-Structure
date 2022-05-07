using System;

public class SinglyLinkedListNode<T>
{
    public T Data { get; set; }

    public SinglyLinkedListNode<T> Next
    { get; set; }

    public SinglyLinkedListNode(T data)
    {
        this.Data = data;
        this.Next = null;
    }
}

public class SinglyLinkedList<T>
{
    private SinglyLinkedListNode<T> head;

    public void Add(SinglyLinkedListNode<T> newNode)
    {
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            //마지막 노드로 이동해 추가
            while (current != null && current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void AddAfter(
        SinglyLinkedListNode<T> current,
        SinglyLinkedListNode<T> newNode)
    {
        if (head == null || current == null || newNode == null)
        {
            throw new InvalidOperationException();
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void Remove(SinglyLinkedListNode<T> removeNode)
    {
        if (head == null || removeNode == null)
        {
            return;
        }

        //삭제할 노드가 첫 노드일 경우
        if (removeNode == head)
        {
            head = head.Next;
            removeNode = null;
        }
        //첫 노드가 아닐 경우 검색하여 삭제 
        else
        {
            var current = head;
            //단방향이므로 삭제할 노드의 바로 이전 노드 검색
            while(current != null && current.Next != removeNode)
            {
                current = current.Next;
            }

            if (current != null)
            {
                //이전 노드의 Next에 삭제노드의 Next 할당
                current.Next = removeNode.Next;
                removeNode = null;
            }
        }
    }

    public SinglyLinkedListNode<T> GetNode(int index)
    {
        var current = head;
        for(int i=0; i<index && current != null; i++)
        {
            current = current.Next;
        }

        //만약 index가 리스트의 길이보다 크다면 null이 반환되게 됨
        return current;
    }

    public int Count()
    {
        int cnt = 0;

        var current = head;
        while(current != null)
        {
            cnt++;
            current = current.Next;
        }
        return cnt;
    }
}


/*

연결 리스트는 각 노드가 데이터와 포인터를 가지고 있으면서 노드들이 한 줄로 쭉 연결되어 있는 방식으로 데이터를 저장하는 자료구조이다
1. 단일 연결 리스트(Singly Linked List)
    - 각 노드가 다음 노드만의 주소를 가지고 있는 연결 리스트
2. 이중 연결 리스트(Doubly Linked List)
    - 노드가 이전 노드의 주소와 다음 노드의 주소 모두 가지고 있어 양방향으로 탐색할 수 있는 연결 리스트

 */