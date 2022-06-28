int numOne;
int numTwo;
int numThree;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result){
        result = arg2;
    }
    if(arg3 > result){
        result = arg3;
    }
    return result;
}

Console.WriteLine("Введите три числа");
Console.Write("Первое число: ");
numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
numTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
numThree = Convert.ToInt32(Console.ReadLine());
int maximum = Max(numOne, numTwo, numThree);
Console.WriteLine();
Console.WriteLine($"Максимальное число: {maximum}");