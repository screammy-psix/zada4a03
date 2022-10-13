//Задача 34: Задайте массив заполненный 
//случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void Zadanie34 ()
{
    int size = 4;
    int [] numbers = new int [size];
    FillArray(numbers);
    PrintArray(numbers);

    int count = 0;
    for (int i = 0; i<size; i ++ )
    {
        if(numbers[i] % 2 == 0) count ++;
    }
    Console.WriteLine("Количество четных элемeнтов "+ count );
}
void FillArray(int[]numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100,1000);
    }
}
void PrintArray(int[]num)
{
for(int i = 0; i<num.Length; i++)
{
    Console.Write(num[i] + " ");
}
Console.WriteLine();
}
//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void Zadanie36()
{
    int size = 4;
    int [] numbers = new int [size];
    FillArray1(numbers);
    PrintArray(numbers);

    int count = 0;
    int sum = 0;
    for (int i = 0; i<size; i ++ )
    {
        if(numbers[i] % 2 == 0) count ++;
        if(i % 2 == 1) sum  += numbers[i];
    }
        Console.WriteLine("Сумма элемeнтов на нечетных позициях: "+ sum );
}
void FillArray1(int[]numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-99,100);
    }
}

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным
// элементов массива.
//[3 7 22 2 78] -> 76
void Zadanie38()
{
    int size = 5;
    double [] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);   
    DiffMinMax(numbers);
}
void DiffMinMax(double[]numbers)
{
    double diff = 0;
    double min = numbers.Min();
    double max = numbers.Max();
    for (int i = 0; i< numbers.Length; i++)
    {
        diff = numbers.Max() - numbers.Min();
    }
    Console.WriteLine($"разница = {diff} ");
}  
void FillArrayDouble(double[]numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        double value = random.NextDouble()*20-10;
        numbers[i] = Math.Round(value, 2);
    }
}
void PrintArrayDouble(double[]num)
{
for(int i = 0; i<num.Length; i++)
{
    Console.Write(num[i] + " ");
}
Console.WriteLine();
}
Zadanie38();