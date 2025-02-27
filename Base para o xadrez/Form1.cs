using System.CodeDom.Compiler;

namespace xadrez;

public partial class Form1 : Form
{
    public static int sizeOfTabuleiro = 8;
    
    private PictureBox pecaSelecionada = null; // Armazena a peça selecionada
    private int origemX = -1, origemY = -1; // Armazena a posição da peça
    public Peça[,] tabuleiro = new Peça[sizeOfTabuleiro,sizeOfTabuleiro];
    public Form1()
    {
        InitializeComponent();
    }
    
    public void cliqueNoTabuleiro(Peça peca)
{

    if (origemX == -1 && origemY == -1) // Primeiro clique: seleciona a peça
    {
        if (peca is not CasaVazia){
            pecaSelecionada = peca.pictureBox;
            origemX = peca.X;
            origemY = peca.Y;
            MessageBox.Show($"Peça selecionada em ({peca.X}, {peca.Y})");
        }
    }
    else // Segundo clique: tenta mover a peça
    {
        Peça pecaOrigem = tabuleiro[origemX, origemY];
        Peça pecaDestino = tabuleiro[peca.X, peca.Y];

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
            
        }

        // Atualiza a interface
        this.Refresh();

        // Reseta os valores para a próxima jogada
        pecaSelecionada = null;
        origemX = -1;
        origemY = -1;
    }
    
}

}
