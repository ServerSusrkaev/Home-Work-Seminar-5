// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Укажите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

Library.FillArray(array);
System.Console.WriteLine("");

int maxNumber = 0;
int minNumber = array[0];
//int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
    else if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
}System.Console.Write("Разница между максимальным и минимальным элементами массива равна: " + (maxNumber - minNumber));