// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// Вводим массив через консоль
int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
void function(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
function(mas);