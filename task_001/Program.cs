// Задайте массив из 12 элементов, заполненный случайными числами из промежутка (-9, 9)
// Найти сумму отрицательных и положительных элементов массива

Console.Clear();
int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(",", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел = {sumPositive}, а отрицательных = {sumNegative}");