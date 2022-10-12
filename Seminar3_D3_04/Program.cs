// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите значение N: ");
int N =int.Parse(Console.ReadLine()??"0");
Console.WriteLine("");

int count = 0;

while(count<=N)
{
    if (count%2==0)
    {
        double cub=Math.Pow((count),3);
        Console.WriteLine($"Куб числа {count}, заканчивается на четную цифру и равен {cub}");
        
    }
    else
    {
        // Console.WriteLine($"Число {count} нечетное, не рассматривается условием!");
        Console.WriteLine("");
    }
    count++;
}

// ver 2

// Console.Write("Введите значение N: ");
// int N =int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("");

// int count = 0;

// while(count<=N)
// {
//    double cub=Math.Pow((count),3);
//    Console.WriteLine($"Куб числа {count}, заканчивается на четную цифру и равен {cub}");
//    count=count+2;
// }

//ver3

//Console.Write("Введите значение N: ");
//double N = double.Parse(Console.ReadLine()??"0");

//double count = 0;
//double cub = 1;


//while(count <= N)
//{
    
//    cub = Math.Pow(count,3);
//    double num = cub % 10;
//    if (num%2==0)
//    {
//        Console.WriteLine ($"Куб числа {count} = {cub}");
//    }
//    count++;
// }

