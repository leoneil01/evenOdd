class Program
{
    static void Main(string[] args)
    {
        int i;

        // prompt user for integer
        Console.Write("Input a number: ");
        i = Convert.ToInt32(Console.ReadLine());

        // check parity of integer
        if (i % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}