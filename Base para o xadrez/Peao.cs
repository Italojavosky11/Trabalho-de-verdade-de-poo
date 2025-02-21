using System;

public class Peao : Peça{
    public Peao(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        int difX = destinoX - X;
        int difY = destinoY - Y;

        // Considerando que o Peão se move apenas para frente
        return (difX == 1 && difY == 0) || (difX == 1 && Math.Abs(difY) == 1);
       
    }

}