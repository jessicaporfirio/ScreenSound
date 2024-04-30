class Banda 
{
    private List<Album> albums = new List<Album>(); //campo privado

    public Banda(string nome)//construtor
    {
        Nome = nome;
    }
    public string Nome { get; } // propriedades

    public void AdicionarAlbum(Album album) // metodo
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"\nÁlbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}