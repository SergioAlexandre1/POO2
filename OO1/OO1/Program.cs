namespace OO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int total = 0;
            int A = 0, B = 0, C = 0, D = 0, E = 0;
            Console.WriteLine("Digite uma idade: ");
            x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                if (x >= 1 && x <= 15)
                {
                    A++;
                    total++;
                }
                else if (x >= 16 && x <= 30)
                {
                    B++;
                    total++;
                }
                else if (x >= 31 && x <= 45)
                {
                    C++;
                    total++;
                }
                else if (x >= 46 && x <= 60)
                {
                    D++;
                    total++;
                }
                else if (x >= 61)
                {
                    E++;
                    total++;
                }
                Console.WriteLine("Digite outra idade: ");
                x = int.Parse(Console.ReadLine());
            }
            if (total > 0)
            {
                Console.WriteLine("\nPorcentagem por faixa etária:");

                Console.WriteLine($"Faixa A (1-15 anos): {(A * 100.0 / total):F2}%");
                Console.WriteLine($"Faixa B (16-30 anos): {(B * 100.0 / total):F2}%");
                Console.WriteLine($"Faixa C (31-45 anos): {(C * 100.0 / total):F2}%");
                Console.WriteLine($"Faixa D (46-60 anos): {(D * 100.0 / total):F2}%");
                Console.WriteLine($"Faixa E (61+ anos): {(E * 100.0 / total):F2}%");
            }
            else
            {
                Console.WriteLine("Nenhuma idade válida foi inserida. ");
            }
        }
    }
}
