using System;
class MyClass
{
    static void FillArray(int[][] userArr)
    {
        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                Console.Write($"Enter the {j + 1} number in {i + 1} array -> ");
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

    static void FindSumArray(int[][] userArr)
    {
        int sumArray = 0;

        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                sumArray += userArr[i][j];
            }
        }
        
        Console.WriteLine($"\nSum your array -> {sumArray}");
    }

    static void FindMaxElement(int[][] userArr)
    {
        int maxElement = userArr[0][0];

        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                if (userArr[i][j] > maxElement)
                {
                    maxElement = userArr[i][j];
                }
            }
        }
        
        Console.WriteLine($"\nMax element your array -> {maxElement}");
    }
    static void FindMinElement(int[][] userArr)
    {
        int minElement = userArr[0][0];

        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                if (userArr[i][j] < minElement)
                {
                    minElement = userArr[i][j];
                }
            }
        }
        
        Console.WriteLine($"\nMin element your array -> {minElement}");
    }

    static void FindAverageValue(int[][] userArr)
    {
        double averageValue;
        
        for (int i = 0; i < userArr.Length; i++)
        {
            int numberCount = 0;
            int columnSum = 0;
            
            for (int j = 0; j < userArr[i].Length; j++)
            {
                columnSum += userArr[i][j];
                numberCount ++;
            }
            
            averageValue = (double)columnSum / numberCount;
            Console.WriteLine($"Average value {i + 1} column is {averageValue:F2}");
        }
    }
    
    static void Main()
    {
        int userSizeColumn, userSizeLine;
        
        Console.Write("Enter the size column your array -> ");
        if (!int.TryParse(Console.ReadLine(), out userSizeColumn) || userSizeColumn <= 0) { Console.WriteLine("Must be a positive number!"); return; }
        int[][] userArr = new int[userSizeColumn][];

        for (int i = 0; i < userSizeColumn; i++)
        {
            Console.Write($"How many elements in column {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out userSizeLine) || userSizeLine <= 0) { Console.WriteLine("Must be a positive number!"); i--; continue; }

            userArr[i] = new int[userSizeLine];
        }
        
        FillArray(userArr);

        while (true)
        {

            Console.WriteLine("\nPress \"1\" - for showing full array" +
                              "\nPress \"2\" - for showing sum your array" +
                              "\nPress \"3\" - for showing max element your array" +
                              "\nPress \"4\" - for showing min element your array" +
                              "\nPress \"5\" - for showing average value your array" +
                              "\nWrite \"Exit\" for exit the program");
            
            Console.Write("\nEnter your choise ->");
            string userChoice = Console.ReadLine()?.ToLower();

            switch (userChoice)
            {
                case "1":
                { ShowArray(userArr); break; }

                case "2":
                { FindSumArray(userArr); break; }

                case "3":
                { FindMaxElement(userArr); break; }

                case "4":
                { FindMinElement(userArr); break; }

                case "5":
                {
                    FindAverageValue(userArr); break;
                }

                case "exit":
                { return; }
                
                default:
                    Console.WriteLine("Try again..."); break;
            }
        }
    }
}