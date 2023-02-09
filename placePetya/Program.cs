Console.Clear();
int[] height = { 155, 156, 150, 149, 159, 160, 145, 155, 147, 156, 148, 161, 162, 155 };
Console.Write("Стоят не по росту: ");
Console.WriteLine(string.Join(", ", height));
int heightPetya = 155;
Console.WriteLine("Рост Пети равен " + heightPetya + " см.");
for (int i = 0; i < height.Length; i++)
{
    for (int j = 0 + i ; j < height.Length; j++)
    {
        if (height[j] > height[i])
        {
            int temp = height[i];
            height[i] = height[j];
            height[j] = temp;
        } 
    }
}
int[] heightSort = new int[height.Length + 1];
bool flag = false;
for (int a = 0; a < heightSort.Length - 1; a++)
{
    if ((height[a] >= heightPetya) && (flag == false))
    {
        heightSort[a] = height[a];
    }
    else if(flag == false) 
    {
        heightSort[a] = heightPetya * 1000; // * 1000 - меткав массиве, что это Петя))
        flag = true;
    }
    if (flag == true)
    {
        heightSort[a + 1] = height[a];
    }
}
Console.Write("Построились без Пети: "); 
Console.WriteLine(string.Join(", ", height));
Console.Write("Построились с Петей: "); 
Console.WriteLine(string.Join(", ", heightSort));        