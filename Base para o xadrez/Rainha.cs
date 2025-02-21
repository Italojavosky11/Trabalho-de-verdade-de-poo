using System;

public class Rainha : Peça{
    public Rainha(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
       return true; // falta a movimentação
       
    }

}