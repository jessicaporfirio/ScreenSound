class Album 
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    
    //Propriedades
 public string Nome { get; }
 public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    // métodos
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica); //Adicionando musica ao album
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
            Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos");
    }
 
}