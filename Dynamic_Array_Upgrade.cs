using System;

public class Dynamic_Array_Upgrade
{
    private object[] array;
    private const int GROWTH_FATOR = 2; //배열 크기 성장인자

    public int Count { get; private set; }

    public int Capacity //현재 Array의 수용력(크기)
    {
        get { return array.Length; }
    }

    //Constructor
    public Dynamic_Array_Upgrade(int capacity = 16)
    {
        array = new object[capacity];
        Count = 0;
    }

    public void Add(object element)
    {
        //배열이 찾을 때 확장한다
        if (Count >= Capacity)
        {
            int newSize = Capacity * GROWTH_FATOR;
            var temp = new object[newSize];
            for(int i=0; i<array.Length; i++) //array -> temp copy
            {
                temp[i] = array[i];
            }
            array = temp; //array 초기화
        }
        array[Count] = element; //add element 마지막 요소뒤에
        Count++;
    }

    public object Get(int index)
    {
        if(index > Capacity - 1) //capaciry-1(array의 마지막 인덱스)
        {
            throw new ApplicationException("Out of Bound");
        }
        return array[index];
    }

}

/*
해당 DinamicArray는 기존의 Dinamic_Array의 단점을 극복하기 위해 흔히 사용되는 방식을 구현한 것이다

기존 DinamicArray는 요소하나를 더하거나 없애는 경우 n개의 모든 요소들을 복사하는 O(n)의 시간이 소요된다는 문제가 있었다
이 같은 단점을 해결하기 위해 흔히 사용되는 방법은 동적 배열의 크기를 2배씩 확장해주는 것이다
즉, 배열의 확장이 필요한 경우 배열 크기가 2배인 새로운 임시 배열을 생성하고 모든 기존 배열 요소들을 새임시 배열에 복사한 후 기존 배열을
해제하는 방식이.
 */