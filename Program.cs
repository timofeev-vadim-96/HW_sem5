// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] array = new int [9];
void FillArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
FillArray(array);
System.Console.WriteLine($"Array: [{String.Join(", ", array)}]");

void CalculateEvenNumbers (int [] array2)
{
    int count = 0;
    foreach (var item in array2)
    {
        if (item%2 == 0) count++;
    }
    System.Console.WriteLine($"Количество четных чисел в массиве = {count}");
}
CalculateEvenNumbers(array);
