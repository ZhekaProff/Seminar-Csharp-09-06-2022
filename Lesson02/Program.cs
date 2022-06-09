// Написать программу возведения числа А в целую стень B

int PowAB(int a, int b)
{
    if(b==0) return 1;
    else return PowAB(a, b - 1) * a;
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()?? "");

Console.WriteLine($"Число {a} в степени {b} равно {PowAB(a,b)}");