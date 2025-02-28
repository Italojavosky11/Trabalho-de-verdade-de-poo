using System;

public class Peao : Peça
{
    public bool PrimeiraJogada { get; private set; } = true;

    public Peao(int x, int y, string img, Enumcor cor) : base(x, y, img, cor)
    {
    }

    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        int diferençaY = destinoY - Y;
        int diferençaX = Math.Abs(destinoX - X);
        if(cor == Enumcor.Branco)
        {
            if(PrimeiraJogada)
            {
                PrimeiraJogada = false;
                return diferençaY >= -2 && diferençaX == 0;
            }

            else{
                return diferençaY == -1 && diferençaX == 0;
            }
        }
        else{
            if(PrimeiraJogada)
            {
                PrimeiraJogada = false;
                return diferençaY <= 2 && diferençaX == 0;
            }

            else{
                
                return diferençaY == 1 && diferençaX == 0;
                
            }
        }
    }
}
