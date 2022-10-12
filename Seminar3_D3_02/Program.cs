// Подсчитать сумму цифр в числе

Console.Write("Введите число для вычесления суммы цифр в числе: ");
int N = int.Parse(Console.ReadLine()??"0");

int count = 0;
int num = 0; 
int sum = 0;
int FirstNum = N; 

if (10<=N)
{
    while(count<N)
        {
            num=N%10;
            sum = sum + num;
            N=N/10;            
        }
    Console.WriteLine($"Сумма чисел введенного числа {FirstNum} равна = {sum}");
}

else

{
    Console.WriteLine("Подсчет суммы недоступен");
}
