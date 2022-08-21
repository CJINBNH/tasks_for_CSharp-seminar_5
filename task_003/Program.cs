// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

Console.Clear();
int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == N)
    {
        j++;
    }
}
if (j > 0)
{
    Console.WriteLine("Такое число есть в данном массиве");
}
else
{
    Console.WriteLine("Такого числа в заданном массиве нет");
}