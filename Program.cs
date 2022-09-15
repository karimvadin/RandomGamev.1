Console.WriteLine("Добро пожаловать, у вас есть 3 попытки. Введите 3 числа");
int b = Convert.ToInt32(Console.ReadLine());
Random x = new Random();
int a = x.Next(-1, 51);
if (a == b)
{
    Console.WriteLine("Поздравляем вы угадали число с 1 попытки!");
}
else
{
    Console.WriteLine("Неверно, попробуйте еще раз");
}
int z = Convert.ToInt32(Console.ReadLine());
if (a == z)
{
    Console.WriteLine("Поздравляем вы угадали число со 2 попытки!");
}
else
{
    Console.WriteLine("Неверно, попробуйте еще раз");
}
int v = Convert.ToInt32(Console.ReadLine());
if (a == v)
{
    Console.WriteLine("Поздравляем вы угадали число с 3 попытки!");
}
else
{
    Console.WriteLine("Вы не угадали число");
}

Console.WriteLine($"Загаданное число: {a}"); 