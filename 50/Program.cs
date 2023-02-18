// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет

int[,] GetArray(int m, int n){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(1, 10);
            }
        }   
    return result;
}

void PrintArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++){
        for (int j = 0; j < inArray.GetLength(1); j++) {
            Console.Write($"{inArray[i,j]} ");
            }
        Console.WriteLine();
    }
}

void PrintNum(int[,] array, int x, int y){
    if (x>array.GetLength(0) || y>array.GetLength(1))
        Console.WriteLine("The number does not exist");
    else Console.WriteLine($"A[{x},{y}]: {array[x-1,y-1]}");
}

Console.Clear();
Console.WriteLine("Please enter row quantity "); 
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter column quantity "); 
int column = int.Parse(Console.ReadLine());
int [,] A = GetArray(row, column);
PrintArray(A);
Console.WriteLine("Please enter row for number: "); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter column for number: "); 
int b = int.Parse(Console.ReadLine());
PrintNum(A,a,b);