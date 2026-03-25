using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a posição inicial: ");
        string[] entrada = Console.ReadLine().Split();

        int x = int.Parse(entrada[0]);
        int y = int.Parse(entrada[1]);
        string direcao = entrada[2];

        Console.Write("Digite a sequência de comandos: ");
        string comandos = Console.ReadLine();

        for (int i = 0; i < comandos.Length; i++)
        {
            char c = comandos[i];

            if (c == 'E')
            {
                if (direcao == "N") direcao = "O";
                else if (direcao == "O") direcao = "S";
                else if (direcao == "S") direcao = "L";
                else if (direcao == "L") direcao = "N";
            }
            else if (c == 'D')
            {
                if (direcao == "N") direcao = "L";
                else if (direcao == "L") direcao = "S";
                else if (direcao == "S") direcao = "O";
                else if (direcao == "O") direcao = "N";
            }
            else if (c == 'M')
            {
                if (direcao == "N") y++;
                else if (direcao == "S") y--;
                else if (direcao == "L") x++;
                else if (direcao == "O") x--;
            }
        }

        Console.WriteLine($"Posição alcançada: {x} {y} {direcao}");
    }
}