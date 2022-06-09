// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Any(int num1, int num2, int pos)
{
    if(pos <= 1) return num1 + num2;
    return Any(num1, num2, pos - 1) + Any(num1, num2, pos - 2);
}
Console.WriteLine("Which first number?");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Which second number?");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("How much numbers?");
int size = int.Parse(Console.ReadLine());
for(int i = 1; i <= size; i++)
{
    Console.Write($"{Any(first,second,i)} ");
}