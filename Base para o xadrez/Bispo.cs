using System;

public class Bispo : Peça{
    public Bispo(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        int difX = Math.Abs(destinoX - X);
        int difY = Math.Abs(destinoY - Y);

        return difX == difY;
     // falta a movimentação
       
    }

}