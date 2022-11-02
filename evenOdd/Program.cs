class Program
{
    static void Main(string[] args)
    {
        int i;

        Console.Write("Input a number: ");
        i = Convert.ToInt32(Console.ReadLine());

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