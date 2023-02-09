int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
Console.Write("Первоначальный массив:  ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Введите сдвиг вправо (положительное число) или сдвиг влево (отрицательное число)");
int div = Convert.ToInt32(Console.ReadLine());
int len;
if (div >= 0)
    len = div;
else
    len = -div;
int[] arrayDiv = new int[len];
int[] arrayTemp = new int[array.Length];
if (div >= 0)
{
    for (int i = 0; i < div; i++)
    {
        arrayDiv[div - i - 1] = array[array.Length - 1 - i];
    }
    for (int i = 0; i < array.Length - div; i++)
    {
        arrayTemp[i + div] = array[i];
    }
    for (int i = 0; i < div; i++)
        {
            arrayTemp[i] = arrayDiv[i];
        }
    Console.Write("Массив, сдвинутый вправо на " + len + " позиций:  ");
    Console.WriteLine(string.Join(", ", arrayTemp));
}
else if (div < 0)
{
    for (int i = 0; i < len; i++)
    {
        arrayDiv[i] = array[i];
    }
    for (int i = 0; i < array.Length - len; i++)
    {
        arrayTemp[i] = array[i + len];
    }
    for (int i = 0; i < len; i++)
    {
        arrayTemp[array.Length + i - len] = arrayDiv[i];
    }
    Console.Write("Массив, сдвинутый влево на " + len + " позиций:  ");
    Console.WriteLine(string.Join(", ", arrayTemp));
}
            
