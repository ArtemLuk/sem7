// // Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)    {
        for (int j = 0; j < n; j++)        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++)    {
        for (int j = 0; j < inArray.GetLength(1); j++)        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int [,] array){
    int S = 0;
    for (int i = 0; i < array.GetLength(0); i++)    {
        for (int j = 0; j < array.GetLength(1); j++)        {
            
            if (j==i) {
                S=S+array[i,j];
            }
        }
    }
    return S;
}

int Sum2(int [,] array){
    int S = 0;
    int min = array.GetLength(0);
    if (array.GetLength(1)<array.GetLength(0)){
    min = array.GetLength(1);}
    for (int a=0; a<min; a++){
     S=S+array[a,a];
    }
    return S;
}

Console.Clear();
Console.WriteLine("Please enter row quantity "); 
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter column quantity "); 
int column = int.Parse(Console.ReadLine());
int [,] A = GetArray(row, column,1,10);
PrintArray(A);
Console.WriteLine();
Console.WriteLine($"The sum is: {Sum2(A)}");
