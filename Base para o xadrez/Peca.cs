using System.ComponentModel.DataAnnotations;

public abstract class Peça{
    public int X, Y;
    public string img = "";
    public PictureBox pictureBox = new PictureBox();
    public Peça(int x, int y, string img){
        
        this.X = x/50;
        this.Y = y/50;

        pictureBox.Location = new Point(x , y);
        pictureBox.Size = new Size(50, 50); // O Tamanho é fixo
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        
        try{
            this.img = Path.Combine(Application.StartupPath, "imagens", img);
             pictureBox.Image = Image.FromFile(this.img); 
             
        }catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);  
        }

    }
    public abstract bool Verificarmovimento(int destinoX, int destinoY);

}