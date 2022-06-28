
void EvenList(int arg1){
    int count = 1;
    int result = 0;
    while(count  <= arg1){
        if(count  % 2 == 0){
            result = count;
            if(count == arg1 || count + 1 == arg1){
                Console.Write(result);
            }
            else{
                Console.Write($"{result},");
            }
        }
        count ++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();
EvenList(number);