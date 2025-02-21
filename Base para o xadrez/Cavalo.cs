using System;

public class Cavalo : Peça{
    public Cavalo(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
       return true; // falta a movimentação
    }

}