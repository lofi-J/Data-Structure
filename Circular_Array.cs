using System;

public class Circular_Array
{
    //원형 테이블에 8명이 앉아 있고 이때 임의의 사람을 지정하여 시계방향으로 한명씩
    //호출하는 경우를 구현
    char[] table = new char[8] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
    int index = 3;
    public void Call()
    {
        for(int i=0; i<8; i++)
        {
            index = (index + 1) % 8;
            Console.Write(table[index] + ", ");
        }
        Console.WriteLine("\b\b ");
    }
}

/*
원형 배열은 배열을 양 끝이 연결된 것처럼 사용할 수 있게한 자료구조이다

원형 버퍼(Circular Buffer), 링 버퍼(Ring Buffer) 라고도 불림

배열의 크기가 N 일 때, 배열의 마지막 요소(N-1)에 도착하면, 다음 배열요소는 첫 번째 요소로 순환되는 구조

원형 배열은 FIFO 구조의 데이터 버퍼에 적합하며, FIFO 구조를 가진 큐(Queue)를 구현하거나 데이터 스트림 버퍼 등을
구현할 때 사용되곤 한다

[구현]
원형 배열은 배열을 순환하는 구조로 만들어야 하므로, 배열의 인덱스를 증가시킬 때 mod(%) 연산자를 사용해
마지막 배열의 다음 익덱스가 첫 번째 인덱스로 돌아오게 한다
ex) index = (index + 1) % Length

설명) index 가 0 이고, 배열의 길이가 8일 때
설명) (index(0) + 1) % 8
설명) 1 % 8 이되어 나눌 수 없어 나머지가 그대로 1이 나오게됨
설명) 결국 0 다음 1 로 인덱스가 증가되고
설명) 인덱스가 마지막 인덱스일 경우 7
설명) (7 + 1) % 8 되어 나머지가 0이 되면서 처음 인덱스 0으로 돌아오게 된다
 */