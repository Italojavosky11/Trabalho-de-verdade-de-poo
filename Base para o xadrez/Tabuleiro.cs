public class Tabuleiro
{
    public Peça[,] tabuleiro = new Peça[8, 8]; // A matriz de peças no tabuleiro

    public bool VerificarXeque(Enumcor cor)
    {
        Rei rei = EncontrarRei(cor);
        return ReiEmXeque(rei);
    }

    public bool VerificarXequeMate(Enumcor cor)
    {
        Rei rei = EncontrarRei(cor);
        if (ReiEmXeque(rei))
        {
            // Verificar se o rei pode se mover para escapar do xeque
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int novaLinha = rei.X + i;
                    int novaColuna = rei.Y + j;

                    // Verificar se a nova posição está dentro do tabuleiro
                    if (novaLinha >= 0 && novaLinha < 8 && novaColuna >= 0 && novaColuna < 8)
                    {
                        Peça destino = tabuleiro[novaLinha, novaColuna];
                        // Verificar se o movimento do rei é válido e se ele ainda está em xeque
                        if (rei.Verificarmovimento(novaLinha, novaColuna) && destino.cor != cor)
                        {
                            return false; // Se o rei pode se mover, não é xeque-mate
                        }
                    }
                }
            }
            return true; // Não há movimentos válidos para escapar do xeque, é xeque-mate
        }
        return false;
    }

    // Método auxiliar para verificar se o rei está em xeque
    private bool ReiEmXeque(Rei rei)
    {
        foreach (var peca in tabuleiro)
        {
            if (peca != null && peca.cor != rei.cor)
            {
                if (peca.Verificarmovimento(rei.X, rei.Y))
                {
                    return true; // O rei está em xeque
                }
            }
        }
        return false;
    }

    // Método auxiliar para encontrar o rei de uma cor
    private Rei EncontrarRei(Enumcor cor)
    {
        foreach (var peca in tabuleiro)
        {
            if (peca is Rei rei && rei.cor == cor)
            {
                return rei;
            }
        }
        return null; // Caso não encontre o rei
    }
}
