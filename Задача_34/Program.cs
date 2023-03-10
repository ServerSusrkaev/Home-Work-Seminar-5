// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.WriteLine("Укажите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

Library.FillArray(array);
System.Console.WriteLine("");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.Write("Количество четных числе в массиве равно: " + count);