// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N ");
double N = double.Parse(Console.ReadLine()?? "0" );

double count = 1;
double a = 1;

while(count<=N)
{
    a=a*count;
    count++;
}
Console.WriteLine($"произведения чисел от 1 до {N} = {a}");
