using System;

public class ArquivoJogo{
    private string caminhoArquivo = "xadrez.txt";
    private string highscores = "podio.txt";
    public int  placar = 0; 
    public void SalvarPontuacao(string jogador, int pontos)
    {
        string entrada = $"{jogador} : {pontos}";
        File.AppendAllText(caminhoArquivo, entrada +Environment.NewLine);
       MessageBox.Show("Jogada salva com sucesso!");


    }
    public void CarregarPontucoes(){
        if (File.Exists(caminhoArquivo)){
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            MessageBox.Show("high scores");
            foreach(string linha in linhas ) MessageBox.Show(linha);
        }

        else{
            Console.WriteLine("nenhua joagada salva");
        }
    }




}