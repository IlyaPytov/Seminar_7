// Напишите программу, которая на вход принимает число, возвращает индексы этого элемента
// в двумерном массиве или же указание, что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        
        Console.WriteLine(""); 
    }
}