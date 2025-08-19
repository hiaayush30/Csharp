using System;

public class JaggedArray
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello There");

        int[][] jaggedArray = new int[3][];
        // "I want an array that has 3 slots, and each slot will hold an int[]."
        // So jaggedArray[0], jaggedArray[1], jaggedArray[2] are all null until you assign them:
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        // Approach 2: initialize everything directly
        int[][] jagged2 = new int[][]
        {
           new int[] { 3, 4, 5 },
           new int[] { 1, 2 },
           new int[] { 6 }
        };

        Console.WriteLine(jagged2[0][1]);
        int[][] yoJagged = new int[5][3];
        yoJagged[0][0] = 10;
        yoJagged[0][1] = 10;
        yoJagged[0][2] = 10;
        // yoJagged[0][3] = 10;
        Console.WriteLine(yoJagged[0][1]);
    }
}