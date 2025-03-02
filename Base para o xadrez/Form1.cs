using System;
namespace xadrez;
partial class Form1 : Form
{
    public static int sizeOfTabuleiro = 8;
    
    private PictureBox pecaSelecionada = null; // Armazena a peça selecionada
    private int origemX = -1, origemY = -1; // Armazena a posição da peça
    public Peça[,] tabuleiro = new Peça[sizeOfTabuleiro,sizeOfTabuleiro];
    public ArquivoJogo arquivoJogo = new ArquivoJogo();
    public bool  vezBranco = true;
    public int numerojogadas = 0;
    public Form1()
    {
        InitializeComponent();

    }
    
    public void cliqueNoTabuleiro(Peça peca)
{

    if (origemX == -1 && origemY == -1) // Primeiro clique: seleciona a peça
    {
        if (peca is not CasaVazia){
            if (vezBranco && peca.cor == Enumcor.Branco){
            pecaSelecionada = peca.pictureBox;
            origemX = peca.X;
            origemY = peca.Y;
            MessageBox.Show($"Peça selecionada em ({peca.X}, {peca.Y})");}
            else if(!vezBranco && peca.cor == Enumcor.Preto)
            {
                pecaSelecionada = peca.pictureBox;
                origemX = peca.X;
                origemY = peca.Y;
                MessageBox.Show($"Peça selecionada em ({peca.X}, {peca.Y})");
            }
            else {
                MessageBox.Show("Vez do outro jogador");
            }
        }
    }
    else // Segundo clique: tenta mover a peça
    {

        Peça pecaOrigem = tabuleiro[origemX, origemY];
        Peça pecaDestino = tabuleiro[peca.X, peca.Y];
        if (pecaOrigem.cor == pecaDestino.cor)
        {
            MessageBox.Show("Movimento Inválido, porque é do mesmo time!");
            pecaSelecionada = null;
            origemX = -1;
            origemY = -1;
            return;
        }

        // Verifica se o movimento é válido
        if (!pecaOrigem.Verificarmovimento(peca.X, peca.Y))
        {
            MessageBox.Show("Movimento Inválido!");
            pecaSelecionada = null;
            origemX = -1;
            origemY = -1;
            return;
        }

        if (pecaDestino is CasaVazia) // Se o destino estiver vazio, apenas move a peça
        {
            // Atualiza a matriz
                // Atualiza a matriz
                tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png", Enumcor.vazio);
                tabuleiro[peca.X, peca.Y] = pecaOrigem;

                // Atualiza as coordenadas da peça movida
                pecaOrigem.X = peca.X;
                pecaOrigem.Y = peca.Y;

                // Atualiza a posição visualmente
                pecaOrigem.pictureBox.Location = new Point(peca.X * 50, peca.Y * 50);
        }
        else // Se houver outra peça, remove a peça
        {
                // Remover peça do tabuleiro
                this.Controls.Remove(pecaDestino.pictureBox);

                // Substitui a peça no tabuleiro
                tabuleiro[peca.X, peca.Y] = pecaOrigem;
                tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png", Enumcor.vazio);

                // Atualiza a posição visualmente
                pecaOrigem.X = peca.X;
                pecaOrigem.Y = peca.Y;
                pecaOrigem.pictureBox.Location = new Point(peca.X * 50, peca.Y * 50);

            if (pecaDestino is Rei){
                switch(pecaDestino.cor){
                    case Enumcor.Branco:
                        MessageBox.Show("Team preto vencedor!");
                        Application.Exit();
                    break;

                    case Enumcor.Preto:
                        MessageBox.Show("Team white vencedor!");
                        Application.Exit();
                    break;
                }
            }
        }
        switch(vezBranco){
            case true: 
                vezBranco = false;
            break;
            case false:
                vezBranco = true;
            break;
        }

        // Atualiza a interface
        this.Refresh();
        arquivoJogo.SalvarJogadas(tabuleiro);

        // Reseta os valores para a próxima jogada
        pecaSelecionada = null;
        origemX = -1;
        origemY = -1;
    }
    
}

}