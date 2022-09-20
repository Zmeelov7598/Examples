Console.WriteLine("Введите первое число!");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число!");

int b = Convert.ToInt32(Console.ReadLine());

void Mod(int a, int b)
{
    if (b % a == 0)
 { 
    Console.WriteLine("Первое число кратно второму ");
 }
    else
  {
    Console.WriteLine("Первое число не кратно второму ");
    Console.WriteLine("Остаток от деления равен " + (b % a));
  }
}

Mod(a,b);
