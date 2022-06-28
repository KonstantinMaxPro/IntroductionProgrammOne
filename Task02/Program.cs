int numOne;
int numTwo;

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
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Большее число: {maximum}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Меньшее число: {minimum}");
}


Console.WriteLine("Введите два числа");
Console.Write("Первое число: ");
numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
numTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
MaxMin(numOne, numTwo);