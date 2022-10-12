// Найти кубы чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
int count = 1;
while (count<=N)
{
    double kub = Math.Pow(count,3); 
    Console.WriteLine($"Куб числа {count} = {kub}");
    count++;          
}
