int a;
int b;
int maximum = 0;
int minimum = 0;
Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    maximum = a;
    minimum = b;
}
else{
    maximum = b;
    minimum = a;
}
Console.WriteLine();
Console.WriteLine($"Большее число: {maximum}\nМеньшее число: {minimum}");