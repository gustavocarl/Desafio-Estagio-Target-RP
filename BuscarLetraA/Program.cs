namespace BuscarLetraA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAMaiusculo = 0, quantidadeAMinusculo = 0;
            Console.WriteLine("Informe uma palavra: ");
            var palavra = Console.ReadLine()!;

            if (palavra.Contains('a'))
                Console.WriteLine($"A palavra {palavra} contém a letra a");

            if (palavra.Contains('A'))
                Console.WriteLine($"A palavra {palavra} contém a letra A");


            foreach (char letra in palavra)
            {
                if (letra == 'a')
                    quantidadeAMinusculo += 1;
                else if (letra == 'A')
                    quantidadeAMaiusculo += 1;
            }

            Console.WriteLine($"A palavra {palavra} possui um total de {quantidadeAMaiusculo} letras A \n" +
                $"A palavra {palavra} possui um total de {quantidadeAMinusculo} letras a");
        }
    }
}
