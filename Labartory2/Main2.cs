
class Program2
{
    static void Main2()
    {   
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть кількість елементів (N): ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Введіть число X: ");
        int X = int.Parse(Console.ReadLine());
        Random rand = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++) numbers.Add(rand.Next(1, 101));
        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));
        for (int i = 0; i < numbers.Count; i++)
        {
            int firstDigit = GetFirstDigit(numbers[i]);
            if (firstDigit % 2 == 0)
            {
                numbers.Insert(i, X);
                i++;
            }
        }
        Console.WriteLine("Колекція після вставки числа X: " + string.Join(", ", numbers));
    }
    static int GetFirstDigit(int num)
    {
        while (num >= 10) num /= 10;
        return num;
    }
}
