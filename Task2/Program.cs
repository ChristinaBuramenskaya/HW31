Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Максимальное число");
    Console.WriteLine(number1);
}
else if (number2 > number1)
{
    Console.WriteLine("Максимальное число");
    Console.WriteLine(number2);
}