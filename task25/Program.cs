Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести это число: ");
int n = Convert.ToInt32(Console.ReadLine());
int xn = 1;
for(int i = 0; i < n; i++)
{
    xn = xn * x;
}
Console.WriteLine($"Число {x} в степени {n} равно {xn}");
