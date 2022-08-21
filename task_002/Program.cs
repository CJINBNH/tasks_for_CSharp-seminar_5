// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот

Console.Clear();
int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = array[i] * (-1);
        array[i] = -array[i]; // равнозначно записи array[i] * (-1)
    }
Console.WriteLine('[' + string.Join(", ", array) + ']');