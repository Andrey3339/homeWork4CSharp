Console.Clear();
int[] arraySimple = new int[168];
int j = 0;
int amount = 0;
for (int i = 2; i < 999; i++)
{
    bool f = false;
    f = simpleNumber(i);
    if (f)
    {
        arraySimple[j] = i;
        j++; amount += 1;
    }
}
Console.WriteLine("Все простые числа от 4 до 999, чтоб проще было подобрать число для тестирования:");
Console.WriteLine(string.Join(" ", arraySimple));
Console.WriteLine("Введите целое четное число в диапазоне от 4 по 998");
int n = Convert.ToInt32(Console.ReadLine());
while ((n < 4 || n > 998) || ((n % 2) != 0))
{
    Console.WriteLine("Некорректный ввод числа...");
    Console.WriteLine("Введите целое четное число в диапазоне от 4 по 998");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = 0;
int n2 = 0;
bool f1 = false;
bool f2 = false;
for (int i = 3; i < n; i++)
{
    n1 = i;
    n2 = n - i;
    f1 = simpleNumber(n1);
    f2 = simpleNumber(n2);
    if (f1 == true && f2 == true)
        {
            Console.WriteLine("Число " + n + " раскладывается на " + n1 + " и " + n2);
            break;
        }
}           
Console.ReadLine();
        

bool simpleNumber(int n)
{
    bool flag = true;
    for (int i = 2; i < n; i++)
    {
        if ((n % i) == 0)
        {
            flag = false;
            break;
        }
    }
    return flag;
}