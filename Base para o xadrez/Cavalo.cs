using System;

public class Cavalo : Peça{
    public Cavalo(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        int difX = Math.Abs(destinoX - X);
        int difY = Math.Abs(destinoY - Y);

        return (difX == 2 && difY == 1) || (difX == 1 && difY == 2);
    }

}