namespace Diamond21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor que deseja no seu diamante(Apenas numeros impares!!): ");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Esse nurmero não é impar!");
                return;
            }

            Console.Write('\n'); Console.Clear();
            Diamond(n);
            Console.WriteLine("\n");

            Console.ReadLine();
        }

        static void Diamond(int size)
        {
            int i, j, space;
            for (i = 1; i <= size; i+=2)
            {
                for (space = 1; space <= (size - i) / 2; space++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }
                
                Console.WriteLine();
            }

            for (i = size - 2; i >= 1; i-=2)
            {
                for (space = 1; space <= (size - i) / 2; space++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}
