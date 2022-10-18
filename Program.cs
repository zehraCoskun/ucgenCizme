internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Eşkenar üçreginin kenar uzunluğunu giriniz");
        int kenar = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= kenar; i++)
        {
            for (int j = 0; j < kenar+i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < kenar-i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            

        }

    }
}