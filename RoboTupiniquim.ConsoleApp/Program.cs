using System;

static class Robo
{
    public static int roboX = 1;
    public static int roboY = 2;
    public static char direcao = 'N';

    public static void Configurar(int rX, int rY, char dir)
    {
        rX = rX;
        rY = rY;
        dir = dir;
    }

    public static void ExecutarComando(string comando)
    {
        for (int i = 0; i < comando.Length; i++)
        {
            char comandoAtual = comando[i];

            if (comandoAtual == 'E')
            {
                Robo.GirarParaEsquerda();
            }
            else if (comandoAtual == 'D')
            {
                Robo.GirarParaDireita();
            }
            else if (comandoAtual == 'M')
            {
                Robo.AvancarRobo();
            }
        }
    }

    public static void AvancarRobo()
    {
        if (direcao == 'N') roboY++;
        else if (direcao == 'S') roboY--;
        else if (direcao == 'L') roboY++;
        else if (direcao == 'O') roboY--;
    }
    public static void GirarParaEsquerda()
    {
        if (direcao == 'N') direcao = 'O';
        else if (direcao == 'O') direcao = 'S';
        else if (direcao == 'S') direcao = 'L';
        else if (direcao == 'L') direcao = 'N';
    }
    public static void GirarParaDireita()
    {
        if (direcao == 'N') direcao = 'L';
        else if (direcao == 'O') direcao = 'N';
        else if (direcao == 'S') direcao = 'L';
        else if (direcao == 'L') direcao = 'S';
    }
}
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

        Robo.Configurar(3, 3, 'L');
       
        Console.WriteLine("-------------------------------------"); 
        Console.WriteLine("Robô Tupiniquim");
        Console.WriteLine("-------------------------------------"); 
        Console.WriteLine("Coordenadas    X Y  Direção");
        Console.WriteLine($"Posição inicial: {Robo.roboX} {Robo.roboY}   {Robo.direcao}");

        Robo.ExecutarComando("EMEMEMEMM");

        Console.WriteLine("\nCoordenadas       X Y Direção");
        Console.WriteLine($"Posição alcançada: {Robo.roboX} {Robo.roboY}   {Robo.direcao}");
        Console.ReadLine();
    }
}