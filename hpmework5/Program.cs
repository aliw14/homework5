namespace hpmework5;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("eded daxil et");
        int number = int.Parse(Console.ReadLine());
        Console.Write("eded daxil et");
        int number2 = int.Parse(Console.ReadLine());

        int count = 0;
        
            for (int r = number; r <=number2; r++)
            {

                if (Math.Sqrt(r)==(int)Math.Sqrt(r) ) 
                {
                    count++;
                }
            }

        Console.WriteLine(count);

    }
    
}


