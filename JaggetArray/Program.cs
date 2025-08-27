using System;

class MyClass
{
    static void GenerateRandomArrays(int[][] userArr)
    {
        Random rnd = new Random();

        for (int i = 0; i < userArr.Length; i++)
        {
            for (int j = 0; j < userArr[i].Length; j++)
            {
                userArr[i][j] = rnd.Next(-51, 51);
            }
        }
    }

    static void ShowLoadingArray()
    {
        Console.WriteLine("\nLoading data...\n");

        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Wait {i} second...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\nData download complete!");
    }

    static void ShowFullArray(int[][] userArr)
    {
        for (int i = 0; i < userArr.Length; i++)
        {
            Console.WriteLine();

            for (int j = 0; j < userArr[i].Length; j++)
            {
                Console.Write(userArr[i][j] + " ");
            }
        }
    }

    static void FindMaxLine(int[][] userArr)
    {
        int maxValue = userArr[0].Sum();
        int indexLine = 0;

        for (int i = 0; i < userArr.Length; i++)
        {
            int sumLine = 0;

            for (int j = 0; j < userArr[i].Length; j++)
            {
                sumLine += userArr[i][j];
            }

            if (maxValue < sumLine)
            {
                maxValue = sumLine;
                indexLine = i;
            }
        }

        Console.WriteLine($"\nMax value with your array is located in {indexLine + 1}, and have value {maxValue}");
    }

    static void FindMinLine(int[][] userArr)
    {
        int minValue = userArr[0].Sum();
        int indexLine = 0;

        for (int i = 0; i < userArr.Length; i++)
        {
            int sumLine = 0;

            for (int j = 0; j < userArr[i].Length; j++)
            {
                sumLine += userArr[i][j];
            }

            if (minValue > sumLine)
            {
                minValue = sumLine;
                indexLine = i;
            }
        }

        Console.WriteLine($"\nMin value with your array is located in {indexLine + 1}, and have value {minValue}");
    }

    static void Main()
    {
        int userSizeColumn, userSizeLine;

        Console.Write("Enter the size column your array -> ");
        if (!int.TryParse(Console.ReadLine(), out userSizeColumn) || userSizeColumn <= 0 || userSizeColumn > 5)
        {
            Console.WriteLine("Your size array must be with 1 to 5");
            return;
        }

        int[][] userArr = new int[userSizeColumn][];

        for (int i = 0; i < userSizeColumn; i++)
        {
            Console.Write($"How many elements in column {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out userSizeLine) || userSizeLine < 3 || userSizeLine > 7)
            {
                Console.WriteLine("Must be a number with 3 to 7");
                i--;
                continue;
            }

            userArr[i] = new int[userSizeLine];
        }

        GenerateRandomArrays(userArr);
        ShowLoadingArray();

        while (true)
        {
            Console.WriteLine("\n\nPress \"1\" -  for showing full array" +
                              "\nPress \"2\" - for showing max Line and his index" +
                              "\nPress \"3\" - for showing min Line and his index" +
                              "\nWrite \"Exit\" for exit the program");

            Console.Write("\nEnter your choice -> ");
            string userChoice = Console.ReadLine()?.ToLower();

            switch (userChoice)
            {
                case "1":
                {
                    ShowLoadingArray();
                    ShowFullArray(userArr);
                    break;
                }

                case "2":
                {
                    ShowLoadingArray();
                    FindMaxLine(userArr);
                    break;
                }

                case "3":
                {
                    ShowLoadingArray();
                    FindMinLine(userArr);
                    break;
                }

                case "exit":
                {
                    return;
                }

                default:
                {
                    Console.WriteLine("\nTry again...");
                    break;
                }
            }
        }
    }
}