Console.Write("Введите число: ");
int n;

try
{
    n = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число");
    return;
}

if (n % 2 == 0)
{
    Console.WriteLine($"{n} - четное число");
}
else
{
    Console.WriteLine($"{n} - нечетное число");
}