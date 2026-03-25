static class Robo
{
    public static int roboX;
    public static int roboY;
    public static char direcao;

    public static void Configurar(int rX, int rY, char dir)
    {
        roboX = rX;
        roboY = rY;
        direcao = dir;
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
