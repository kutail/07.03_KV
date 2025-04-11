namespace _07._03_KV
{
    internal class Program
    {
        static void Main()
        {
            Money a = new Money(10.52);
            Money b = new Money(5.1);

            Money addResult = a + b;
            Console.WriteLine($"Сложение: {a} + {b} = {addResult}");
            Money subResult = a - b;
            Console.WriteLine($"Вычитание: {a} - {b} = {subResult}");
            Money mulResult = a * 3;
            Console.WriteLine($"Умножение: {a} * 3 = {mulResult}");
            Money divResult = a / 2;
            Console.WriteLine($"Деление: {a} / 2 = {divResult}");
            Money incResult = a++;
            Console.WriteLine($"Инкремент: a++ = {a} (возвращает {incResult})");
            Money decResult = b--;
            Console.WriteLine($"Декремент: b-- = {b} (возвращает {decResult})");
            Console.WriteLine($"Сравнение: {a} > {b} = {a > b}");
            Console.WriteLine($"Сравнение: {a} < {b} = {a < b}");
            Console.WriteLine($"Сравнение: {a} == {b} = {a == b}");
            Console.WriteLine($"Сравнение: {a} != {b} = {a != b}");
            Console.WriteLine($"Отрицательность: {a}.IsNegative() = {a.IsNegative()}");
            Console.WriteLine($"Отрицательность: {subResult}.IsNegative() = {subResult.IsNegative()}");
        }
    }
}
