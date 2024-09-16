class Program
{
    static void Main()
    {   
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть кількість елементів (N): ");
        int N = int.Parse(Console.ReadLine());
        Random rand = new Random();
        List<int> numbers = new List<int>();
        List<int> primes = new List<int>();
        List<int> nonPrimes = new List<int>();

        for (int i = 0; i < N; i++) numbers.Add(rand.Next(1, 51));
        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));

        foreach (int number in numbers)
        {
            if (IsPrime(number)) primes.Add(number);
            else nonPrimes.Add(number);
        }

        Console.WriteLine("Прості числа: " + string.Join(", ", primes));
        Console.WriteLine("Інші числа: " + string.Join(", ", nonPrimes));
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

