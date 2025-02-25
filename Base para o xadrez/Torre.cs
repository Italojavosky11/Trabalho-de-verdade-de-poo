using System;

public class Torre : Peça{
    public Torre(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        return destinoX == X || destinoY == Y;    }

}