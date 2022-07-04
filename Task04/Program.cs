int numberOne;
int numberTwo;
int numberThree;

int MaxNumber(int arg1, int arg2, int arg3)//функция определения максимального числа
{
    int result = arg1;
    if(arg2 > result)
    {
        result = arg2;
    }
    if(arg3 > result)
    {
        result = arg3;
    }
    return result;
}
//ВНЕШНИЙ ВИД ПРОГРАММЫ КОНСОЛИ
Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("==============================");
Console.WriteLine("МАКСИМАЛЬНОЕ ИЗ ТРЕХ ЧИСЕЛ");//Название
Console.WriteLine("==============================\n");
/*КОНЕЦ ЗАГОЛОВКА*/


Console.Write("Введите первое число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out numberOne))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите первое число: ");
}
Console.Write("Введите второе число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out numberTwo))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите второе число: ");
}
Console.Write("Введите третье число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out numberThree))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите третье число: ");
}

int maximum = MaxNumber(numberOne, numberTwo, numberThree);//Вводим параметры для функции

/*Ответ с оформлением*/
Console.WriteLine("\n==============================");
Console.WriteLine($"Максимальное число: {maximum}");
Console.WriteLine("==============================");