using System;

class Program
{
    static int ReadData()
    {
        Console.Write("Enter the size of the X: ");
        string input = Console.ReadLine();
        int size;
        while (!int.TryParse(input, out size) || size <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
            input = Console.ReadLine();
        }
        return size;
    }

    static void print_x_shape(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j || i + j == size - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int size = ReadData();
        print_x_shape(size);
    }
}