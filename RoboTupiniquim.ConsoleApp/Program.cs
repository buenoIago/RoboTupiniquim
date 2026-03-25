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