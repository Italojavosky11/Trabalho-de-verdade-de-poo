//projeto feito por: Italo Javosky da Silva camilo e Manoel Vinicios da Silva

using System;
public class CasaVazia : Peça{
    public  CasaVazia(int x, int y, string img, Enumcor cor) : base( x, y,  img, cor){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {
        return true;
    }    
}