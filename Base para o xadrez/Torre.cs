//projeto feito por: Italo Javosky da Silva camilo e Manoel Vinicios da Silva

using System;
public class Torre : Peça{
    public Torre(int x, int y, string img, Enumcor cor) : base( x, y,  img, cor){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY)
    {

        return destinoX == X || destinoY == Y;    }

    }

