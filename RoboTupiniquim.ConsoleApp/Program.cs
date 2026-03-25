using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        /*
        Console.Write("Digite a posição inicial X: ");
        int roboX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a posição inicial Y: ");
        int roboY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a direção: (N, S, L, O)");
        char direcao = Convert.ToChar(Console.ReadLine());
        */

        int roboX = 1;
        int roboY = 2;
        char direcao = 'N';

        string comando = "EMEMEMEMM";
       
        Console.WriteLine("-------------------------------------"); 
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------------------"); 
        Console.WriteLine("Coordenadas    X Y  Direção");
        Console.WriteLine($"Posição inicial: {roboX} {roboY}   {direcao}");

        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            if (comandoAtual == 'E')
            {
                if (direcao == 'N') direcao = 'O';
                else if (direcao == 'O') direcao = 'S';
                else if (direcao == 'S') direcao = 'L';
                else if (direcao == 'L') direcao = 'N';
            }
            else if (comandoAtual == 'D')
            {
                if (direcao == 'N') direcao = 'L';
                else if (direcao == 'O') direcao = 'N';
                else if (direcao == 'S') direcao = 'L';
                else if (direcao == 'L') direcao = 'S';
            }
            else if (comandoAtual == 'M')
            {
                if (direcao == 'N') roboY++;
                else if (direcao == 'S') roboY--;
                else if (direcao == 'L') roboY++;
                else if (direcao == 'O') roboY--;
            }
        }

        Console.WriteLine("\nCoordenadas       X Y Direção");
        Console.WriteLine($"Posição alcançada: {roboX} {roboY}   {direcao}");
        Console.ReadLine();
    }
}