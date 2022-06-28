int number;
void Even(int arg1){
if(arg1 % 2 == 0){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число {arg1}: ЧЁТНОЕ");
}
else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {arg1}: НЕЧЁТНОЕ");
}
}
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();
Even(number);
