using System;

public class Peao : Peça{
    public Peao(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
       return true; // falta a movimentação
       
    }

}