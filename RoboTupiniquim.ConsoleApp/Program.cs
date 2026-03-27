using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            
        Console.Clear();

        Console.Write("Digite a posição inicial X: ");
        Robo.roboX = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a posição inicial Y: ");
        Robo.roboY = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a direção: (N, S, L, O): ");
        Robo.direcao = Convert.ToChar(Console.ReadLine().ToUpper());

        Robo.Configurar(Robo.roboX, Robo.roboY, Robo.direcao);
       
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
}