int number;

void Even(int arg1)//Функция проверки на чётность
{
    if(arg1 % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ЧЁТНОЕ");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("НЕЧЁТНОЕ");
        Console.ResetColor();
    }
}

//ВНЕШНИЙ ВИД ПРОГРАММЫ КОНСОЛИ
Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("==============================");
Console.WriteLine("ПРОВЕРКА ЧИСЛА НА ЧЁТНОСТЬ");//Название
Console.WriteLine("==============================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите число: ");
}
/*Ответ с оформлением*/
Console.WriteLine("\n==============================");
Console.Write($"Число {number}: ");
Even(number);
Console.WriteLine("==============================");

