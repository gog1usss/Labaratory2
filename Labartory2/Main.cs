
class Program1
{
    static void Main1()
    {   
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть кількість елементів (N): ");
        int N = int.Parse(Console.ReadLine());
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++) numbers.Add(random.Next(1, 51));
        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));
        int min = numbers.Min();
        numbers.Remove(min);
        Console.WriteLine("Колекція після видалення першого мінімального числа (" + min + "): " + string.Join(", ", numbers));
        int max = numbers.Max();
        numbers.Remove(max);
        Console.WriteLine("Колекція після видалення першого максимального числа (" + max + "): " + string.Join(", ", numbers));
    }
}
