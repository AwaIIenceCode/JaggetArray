# JaggedArrayTasks

A collection of console tasks in C# that work with jagged arrays.  
This repository contains small console programs for learning array manipulation, sums, averages, and array transformations.

## Tasks Overview

1. **Manual Array Input**  
   Enter array elements manually, then display, sum, find max/min, calculate averages, or reverse arrays.

2. **Random Array Generator**  
   Automatically generate jagged arrays with random numbers and find the row with max/min sum.

3. **Array Operations**  
   - Display full array  
   - Find maximum and minimum element  
   - Calculate sum of elements  
   - Calculate average value per row  
   - Reverse array rows  
   - Find row with max/min sum  

## How to Run

1. Clone the repository:

```bash
git clone <your-repo-url>
```

Example Output
Task 1: Manual Array Input

Enter the size column your array -> 2
How many elements in column 1: 3
How many elements in column 2: 4

Enter the 1 number in 1 array -> 5
Enter the 2 number in 1 array -> -2
Enter the 3 number in 1 array -> 7
Enter the 1 number in 2 array -> 0
Enter the 2 number in 2 array -> 4
Enter the 3 number in 2 array -> -1
Enter the 4 number in 2 array -> 3

Press "1" - for showing full array
Press "2" - for showing sum your array
Press "3" - for showing max element your array
Press "4" - for showing min element your array
Press "5" - for showing average value your array
Press "6" - for showing upheaval array
Write "Exit" for exit the program

Enter your choice -> 1

Your array ->
5 -2 7
0 4 -1 3

Enter your choice -> 2

Sum your array -> 16

Enter your choice -> 3

Max element your array -> 7

Enter your choice -> 4

Min element your array -> -2

Enter your choice -> 5

Average value of row 1 is 3.33
Average value of row 2 is 1.50

Enter your choice -> 6

Your array ->
7 -2 5
3 -1 4 0

Task 2: Random Array Generator

Enter the size column your array -> 3
How many elements in column 1: 4
How many elements in column 2: 3
How many elements in column 3: 5

Loading data...
Wait 3 second...
Wait 2 second...
Wait 1 second...

Data download complete!

Press "1" - for showing full array
Press "2" - for showing max sum row and its index
Press "3" - for showing min sum row and its index
Write "Exit" for exit the program

Enter your choice -> 1

Your array ->
12 -3 0 7
4 5 -2
10 0 -1 3 2

Enter your choice -> 2

Max sum row is located at row 3, with sum 14

Enter your choice -> 3

Min sum row is located at row 2, with sum 7
