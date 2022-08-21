// Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"; M = 13; N = 20. -> "15, 18"
void Zadacha64()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int i = m;
        if ((m < 1) || (n < m))
        {
            Console.WriteLine("Введенные числа некорректны");
            return;
        }
        while (i <= n)
        {
            if (i % 3 == 0)
            {
                Console.Write(i + " ");
                i += 3;
            }
            else i += 1;
        }
    }
//Zadacha64();

// Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Zadacha66()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int i = m;
        int sum = 0;
        if ((m < 1) || (n < m))
        {
            Console.WriteLine("Введенные числа некорректны");
            return;
        }
        while (i <= n)
        {
            sum += i;
            ++i;
        }
        Console.WriteLine("Cумма элементов от {0} до {1}: {2}", m, n, sum);
    }
//Zadacha66();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n +1;
    }
    if (m > 0 && n == 0)
    {
        return akkerman(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return akkerman(m - 1, akkerman(m, n - 1));
    }
    return -1; //проверка на ошибку (если вывод -1 - m и n некорректные)
}
void Zadacha68()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("A(m,n)= " + akkerman(m,n));
    }
//Zadacha68();