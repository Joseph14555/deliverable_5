namespace deliverable_5
{
    using System;
}
class Program
{

    static int[] MakeArray(int count)
    {
        int[] arr = new int[count];
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            arr[i] = random.Next(10, 50);
        }
        Console.Write("The elements of the arrays are: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
        return arr;

    }

    static int SumArray(int[] arr)
    {
        int total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        return total;
    }
    static void Main(string[] args)
    {
        int count = 0;
        bool valid = false;
        while (!valid)
        {
            try
            {
                Console.Write("Enter a number between 5 and 15: ");
                count = Convert.ToInt32(Console.ReadLine());
                if (count < 5 || count > 15)
                {
                    Console.WriteLine("Error: Number not in range.");
                }
                else { valid = true; }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: invalid number.");
            }
        }
        int[] arr = MakeArray(count);
        int total = SumArray(arr);
        Console.WriteLine("The sum is: {0}", total);
    }
}
