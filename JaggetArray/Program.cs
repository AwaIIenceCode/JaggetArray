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

    static void FindSumArray(int [][] userArr)
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
                              "\nPress \"3\" - for ..." +
                              "\nPress \"4\" - for ..." +
                              "\nPress \"5\" - for ..." +
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
                {
                    break;
                }

                case "4":
                {
                    break;
                }

                case "5":
                {
                    break;
                }

                case "Exit":
                { return; }
                
                default:
                    Console.WriteLine("Try again..."); break;
            }
        }
    }
}