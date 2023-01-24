// Принимает 2 числа и выдает наибольшее
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("Наибольшее число: a");
    return a;
}
else
{
    Console.Write("Наибольшее число: b");
    return b;
}


