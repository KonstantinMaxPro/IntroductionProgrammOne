int number;

void EvenList(int arg1)//Функция вывода чётных чисел от 1 до number
{
    int count = 2;
    int result = 0;
    while(count  <= arg1)
    {
        if(count  % 2 == 0)
        {
            result = count;
            if(count == arg1 || count + 1 == arg1)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write($"{result}, ");
            }
        }
        count ++;
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


Console.WriteLine("\n==============================");
Console.ForegroundColor = ConsoleColor.Yellow;//описание ответа желтого цвета
Console.Write($"Чётные числа от 1 до {number}: ");
Console.ResetColor();
EvenList(number);
Console.WriteLine("\n==============================");
