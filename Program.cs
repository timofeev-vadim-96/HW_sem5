// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double [] array = new double [4];
void FillArray (double [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round (array[i], 3);
    }
}
FillArray(array);
System.Console.WriteLine($"Array: [{String.Join(", ", array)}]");
System.Console.WriteLine();
void FindMaxAndMin (double [] array2)
{
    double max = array2[0];
    double min = array2[0];
    for (int i = 1; i < array2.Length; i++)
    {
        if (array[i] > max) max = array [i];
        if (array[i] < min) min = array [i];
    }
    double dif = max - min;
    System.Console.WriteLine($"Разница между макс.эл. {max} и мин.эл. {min} = {dif}");
}
FindMaxAndMin(array);