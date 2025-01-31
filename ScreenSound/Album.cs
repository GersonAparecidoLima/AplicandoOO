class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    
    public int Duracao { get; set; }  // Duração em segundos
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do Álbum{Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música : {musica.Nome}");
        }
        Console.WriteLine($"para ouvir este álbum interiro você precisa de : {DuracaoTotal}");

    }

}