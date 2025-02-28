using System;

public class Peao : Peça
{
    public bool PrimeiraJogada { get; private set; } = true;

    public Peao(int x, int y, string img, Enumcor cor) : base(x, y, img, cor)
    {
    }

    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        int difX = destinoX - X;
        int difY = destinoY - Y;

        // Define a direção do peão com base na corS
        int direcao = (cor == Enumcor.Branco) ? 1 : -1;

        // Movimento para frente
        if (difX == 0)
        {
            // Movimento de uma casa
            if (difY == direcao)
            {
                PrimeiraJogada = false; // Após o primeiro movimento, não pode mais avançar duas casas
                return true;
            }
            // Movimento de duas casas (apenas na primeira jogada)
            if (PrimeiraJogada && difY == 2 * direcao)
            {
                PrimeiraJogada = false;
                return true;
            }
        }
        // Captura na diagonal
        else if (Math.Abs(difX) == 1 && difY == direcao)
        {
            PrimeiraJogada = false;
            return true;
        }

        return false; // Movimento inválido
    }
}