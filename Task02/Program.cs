int numberFirst;
int numberSecond;

void MaxMin(int arg1, int arg2)
{
    int maximum = 0;
    int minimum = 0;
    if(arg1 > arg2){
        maximum = arg1;
        minimum = arg2;
    }
    else{
        maximum = arg2;
        minimum = arg1;
    }
    Console.Write("Число ");
    Console.ForegroundColor = ConsoleColor.Green;//Даем зеленый цвет большему числу
    Console.Write(maximum);
    Console.ResetColor();//сброс на стандартный цвет
    Console.Write(" больше числа ");
    Console.ForegroundColor = ConsoleColor.Red;//Даем красный цвет меньшему числу
    Console.WriteLine(minimum);
    Console.ResetColor();//сброс на стандартный цвет
}
//ВНЕШНИЙ ВИД ПРОГРАММЫ КОНСОЛИ
Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("==============================");
Console.WriteLine("ОТНОШЕНИЕ ДВУХ ЧИСЕЛ");//Название
Console.WriteLine("==============================\n");
/*КОНЕЦ ЗАГОЛОВКА*/
Console.Write("Введите первое число: ");
/*Проверка ввода первого числа на int*/
while (!int.TryParse(Console.ReadLine(), out numberFirst))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите первое число: ");
}

Console.Write("Введите второе число: ");
/*Проверка ввода второго числа на int*/
while (!int.TryParse(Console.ReadLine(), out numberSecond))
{
    Console.ForegroundColor = ConsoleColor.Red;//ошибка красного цвета
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");   
    Console.ResetColor();
    Console.Write("Введите второе число: ");
}
/*Ответ с оформлением*/
Console.WriteLine("\n==============================");
MaxMin(numberFirst, numberSecond);
Console.WriteLine("==============================");