using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type the number");
        int n = int.Parse(Console.ReadLine());
        int left_sum = 0;
        int right_sum = 0;

        for (int i = 0; i < n; i++)
            left_sum += Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
            right_sum += Convert.ToInt32(Console.ReadLine());

        if (left_sum == right_sum)
            Console.WriteLine($"Yes, sum = {left_sum}");
        else
            Console.WriteLine($"No, difference = {Math.Abs(left_sum - right_sum)}");
    }
}
