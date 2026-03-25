using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Robô Tupiniquim");
        Console.Write("Digite a posição inicial X: ");
        int roboX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a posição inicial Y: ");
        int roboY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a direção: (N, S, L, O)");
        string direcao = Console.ReadLine();

        Console.WriteLine("Digite a sequência de comandos: (Ex. E, D, M)");
        string sequenciaComandos = Console.ReadLine();

        for (int i = 0; i < sequenciaComandos.Length; i++)
        {
            char c = sequenciaComandos[i];

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
                if (direcao == "N") roboY++;
                else if (direcao == "S") roboY--;
                else if (direcao == "L") roboX++;
                else if (direcao == "O") roboX--;
            }
        }

        Console.WriteLine($"Posição alcançada: {roboX} {roboY} {direcao}");
    }
}