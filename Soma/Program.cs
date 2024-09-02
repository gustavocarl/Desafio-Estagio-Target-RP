namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 12, soma = 0, k = 1;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                Console.WriteLine($"{k}º: {soma}");
            }
        }
    }
}
