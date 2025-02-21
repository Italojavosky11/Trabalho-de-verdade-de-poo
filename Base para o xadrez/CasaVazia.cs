
public class CasaVazia : Peça{
    public  CasaVazia(int x, int y, string img) : base( x, y,  img){
        
    }
    public override bool Verificarmovimento(int destinoX, int destinoY){
        return true;
    }

}