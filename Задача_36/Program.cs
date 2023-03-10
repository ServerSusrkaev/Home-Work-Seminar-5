//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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