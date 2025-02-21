using System;

public class Rainha : Peça{
    public Rainha(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {

        // a rainha se movimenta em linha reta ou em diagonal
        int difX = Math.Abs(destinoX - X);
        int difY = Math.Abs(destinoY - Y);

        return (difX == 0 || difY == 0 || difX == difY);
       
    }

}