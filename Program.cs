// Задача 37 со звездочкой, дополнительная: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Сломал себе мозг, пока сделал. Наверняка можно проще, но как додумал...))

int [] array = new int [7];
void FillArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
FillArray(array);
System.Console.WriteLine($"Array: [{String.Join(", ", array)}]");
void CouplesProduct (int [] array2)
{
    int size = array2.Length;
    int size2 = size/2;
    if (size%2 == 1) size2=(size/2) +1;
    int j = size-1;
    int [] array3 = new int [size2];
    for (int i = 0; i < size/2; i++)
    {
        int product = array2[i] * array2[j];
        array3[i] = product;
        j--;
    }
    if (size%2 == 1) array3[j] = array[j];
    System.Console.WriteLine($"Массив из произведений пар массива : [{String.Join(", ", array3)}]");
}
CouplesProduct(array);