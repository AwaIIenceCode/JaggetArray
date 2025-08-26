using System;
class MyClass
{
    static void FillArray(int[][] userArr)
    {
        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                Console.Write($"Enter the {j + 1} number -> ");
                string? input = Console.ReadLine()?.Trim();
                
                if (int.TryParse(input, out int value))
                {
                    userArr[i][j] = value;
                }

                else
                {
                    Console.WriteLine("Error. Must be a number, try again...");
                    j--;
                    continue;
                }
            }
        }
    }
    static void ShowArray(int[][] userArr)
    {
        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                Console.Write(userArr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int userSizeColumn, userSizeLine;
        
        Console.WriteLine("Enter the size column your array -> ");
        if (!int.TryParse(Console.ReadLine(), out userSizeColumn) || userSizeColumn <= 0) { Console.WriteLine("Must be a positive number!"); return; }
        int[][] userArr = new int[userSizeColumn][];

        for (int i = 0; i < userSizeColumn; i++)
        {
            Console.WriteLine($"How many elements in column {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out userSizeLine) || userSizeLine <= 0) { Console.WriteLine("Must be a positive number!"); i--; continue; }

            userArr[i] = new int[userSizeLine];
        }
        
        FillArray(userArr);
        ShowArray(userArr);
    }
}