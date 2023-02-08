Console.Clear();
Console.WriteLine("Введите число, сумму цифр которого нужно узнать: ");
string xString = Console.ReadLine();
long sum = 0;
long x = Convert.ToInt64(xString.Trim());
long xPart = x;
for(int i = 0; i < xString.Trim().Length; i++)
{
    sum = sum + (xPart % 10);
    xPart = xPart / 10;
}
Console.WriteLine($"Сумма цифр числа {x} равна {sum}.");

