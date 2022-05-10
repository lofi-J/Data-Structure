using System;

//Queue Using CircularArray
public class QueueUsingCircularArray
{
    private object[] a;
    private int front;
    private int rear;

    //default size
    public QueueUsingCircularArray(int queueSize = 16)
    {
        a = new object[16];
        front = -1;
        rear = -1;
    }

    public void Enqueue(object data)
    {
        //Check if the queue is full
        if ((rear + 1) % a.Length == front)
        {
            throw new ApplicationException("Full");
        }
        else
        {
            //if First enqueue
            if (front == -1)
            {
                front++;
            }

            //Add Data
            rear = (rear + 1) % a.Length;
            a[rear] = data;
        }
    }

    public object Dequeue()
    {
        //Check if the queue is Empty
        if (front == -1 && rear == -1)
        {
            throw new ApplicationException("Empty");
        }
        else
        {
            //read Data
            object data = a[front];

            //if read the last data
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                //move front
                front = (front + 1) % a.Length;
            }
            return data;
        }
    }


}

//1차원 배열을 이용한 Queue를 구현할 때 값을 dequeue 했을 경우 front의 인덱스가 증가하는 경우와,
//front인데스는 그대로 있고 모든 요소들을 한칸씩 앞으로 이동하는 경우 이렇게 2가지의 방법이 있는데,
//전자의 경우 고정적인 배열의 크기가 한번 찼을 경우엔 다시 데이터를 enqueue할 수 없지만 연산 비용이 적게 소모되고,
//후자의 경우 배열의 크기가 한번 다 찼을 경우에도 dequeue 된 많큼 다시 enqueue할 수 있게 된다 하지만,
//매번 모든 요소를 이동해야하므로 많은 비용이 발생하게 된다.

//해결책 (원형큐)
//구현 과정
/*

1. Queue의 초기 상태에서 Front와 Rear 인덱스는 -1
2. Queue에 데이터를 처음 추가할 때 [0]에 넣고 Front, Rear는 0
3. Enqueue를 진행할 때 가득 찬 상태인지 확인하고, 가득 차지 않았으면 다음 위치(Rear + 1) % Queue.Length 위치로 이동하여 삽입
    - 가득찬 상태인지 확인하는 법 = Rear의 다음 인덱스가 Front이면 가득찬 상태이다. ex) (Rear + 1) % Queue.Length == Front

4. Queue에서 데이터를 읽어 제거할 때는 먼저 Queue가 비어있는지 확인, 비어있지 않으면 데이터를 읽고 Front를 하나 증가시킨다.
    - Front의 증가 = Front = (Front + 1) % Queue.Length

5. Queue의 마지막 요소를 읽어낼 때 즉, Front == Rear 인 상태에서 데이터를 읽은 후 Front, Rear를 -1 로 초기화,
    이는 Queue의 초기상태와 같은데 Queue가 비어있음을 나타낸다.

 */