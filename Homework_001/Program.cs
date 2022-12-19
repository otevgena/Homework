//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Наибольшее число {a}");
}
else
{
    Console.WriteLine($"Наибольшее число {b}");
}


