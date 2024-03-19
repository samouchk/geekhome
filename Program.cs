Console.Clear();
//======================================================\\\\\\\\\\\\
string Nto1(int a, int b)
{
    if (a < b)
        return "";
    return Nto1(a,b+1) + $"{b}, ";
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
Console.WriteLine(Nto1(a,b));

Console.WriteLine("=========================================================");
string Nto1V2(int a, int b)
{
    if (a == 0)
        return "";
    return Nto1V2(a-1,b) + $"{b-a} ";
}
Console.Write("Введите число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = a+1;
Console.WriteLine(Nto1V2(a2,b2));

Console.WriteLine("=========================================================");

int MtoNsumm(int m, int n)
{
    if (n==m)
        return 1;
    return MtoNsumm(m,n-1) + n;
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в диапозоне от {m} до {n} = {MtoNsumm(m,n)}");
Console.WriteLine("=========================================================");
int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
         return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.WriteLine("Введите числа для функции Аккермана: ");
Console.WriteLine("Введите первое число: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана = {Ackermann(m2,n2)}");