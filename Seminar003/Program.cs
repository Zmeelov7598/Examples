Console.WriteLine("Введите числа!");

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.Write("Первое число является квадратом второго числа YES");
}
else
{
    Console.Write("Первое число НЕ является квадратом второго числа NO");
}