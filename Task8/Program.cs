Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= x)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
        count = count + 1;
    }
    else if (count % 2 != 0)
    {
        count = count + 1;
    }
}
