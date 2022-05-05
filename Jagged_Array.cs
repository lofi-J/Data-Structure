using System;

//가변 배열 예제 
public class Jagged_Array
{
    public void TempFuncForTest()
    {
        int[][] A = new int[3][];
        A[0] = new int[2];
        A[1] = new int[6] { 1, 2, 3, 4, 5, 6 };
        A[2] = new int[3] { 7, 8, 9 };

        foreach(int[] x in A)
        {
            foreach(int z in x)
            {
                Console.Write(z + ", ");
            }
            Console.WriteLine("\b\b ");
        }
    }
}
/*
    0, 0  
    1, 2, 3, 4, 5, 6  
    7, 8, 9  
 */