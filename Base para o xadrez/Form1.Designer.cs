namespace xadrez;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 500);
        this.Text = "Xadrez";
  
        InicializarTabuleiro();
              
        
    }

    public void InicializarTabuleiro()
    {
        for(int i = 0; i < 8 ;i++){
            for(int j = 0; j<8 ;j++){
                int x = j, y = i;
                 tabuleiro[x,y] = new CasaVazia(x*50, y*50,"casaVazia.png");
                 this.Controls.Add(tabuleiro[x,y].pictureBox);
                 tabuleiro[x,y].pictureBox.BringToFront();
                 tabuleiro[x,y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x,y]); };
            }   
        }
        
        Rei reiBranco = new Rei(100,150,"reiBranco.png");
        criarpeça(reiBranco);

        Rei reiPreto = new Rei(100,200,"reiPreto.png");
        criarpeça(reiPreto);

        Rainha rainhaBranca = new Rainha(100, 250, "rainhaBranca.png");
        criarpeça(rainhaBranca);

        Rainha rainhaPreta = new Rainha(100, 300, "rainhaPreta.png");
        criarpeça(rainhaPreta);

        Torre torreBranca = new Torre(100,350, "torreBranca.png");
        criarpeça(torreBranca);

        Torre torrePreta = new Torre(300,100 , "torrePreta.png");
        criarpeça(torrePreta);

        Bispo bispoBranco = new Bispo(300, 150, "bispoBranco.png");
        criarpeça(bispoBranco);

        Bispo bispoPreto = new Bispo(300, 200, "bispoPreto.png");
        criarpeça(bispoPreto);

        Cavalo cavaloBranco = new Cavalo(300, 250, "cavaloBranco.png");
        criarpeça(cavaloBranco);

        Cavalo cavaloPreto = new Cavalo(300, 300, "cavaloPreto.png");
        criarpeça(cavaloPreto);


    
    }
    public void criarpeça(Peça peca)
    {
     tabuleiro[peca.X, peca.Y] = peca;
        this.Controls.Add(peca.pictureBox);
        peca.pictureBox.BringToFront();
        peca.pictureBox.Click += (sender, args) => 
        {
            cliqueNoTabuleiro(peca);
        };
    }
     #endregion
}

