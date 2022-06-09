// Найти сумму цифр числа
int RecSum(int num)
{
    if (num % 10 == 0)
        return num;
    return num % 10 + RecSum(num / 10);
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа = {Math.Abs(RecSum(num))}");
