// objetos
Banda marilia = new Banda("Marilia");

Album albumDaMarilia = new Album("Todos os Cantos");

Musica musica1 = new Musica(marilia, "Todo Mundo Vai Sofrer")
{
    Duracao = 169,
    Disponivel = true,
};
Musica musica2 = new Musica(marilia, "Ciumeira")
{
    Duracao = 173,
    Disponivel = true,
};
Musica musica3 = new Musica(marilia, "Bem Pior que Eu")
{
    Duracao = 162,
    Disponivel = false,
};
Musica musica4 = new Musica(marilia, "Bye Bye")
{
    Duracao = 170,
    Disponivel = true,
};
Musica musica5 = new Musica(marilia, "Supera")
{
    Duracao = 162,
    Disponivel = true
};

albumDaMarilia.AdicionarMusica(musica1);
albumDaMarilia.AdicionarMusica(musica2);
albumDaMarilia.AdicionarMusica(musica3);
albumDaMarilia.AdicionarMusica(musica4);
albumDaMarilia.AdicionarMusica(musica5);
marilia.AdicionarAlbum(albumDaMarilia);

albumDaMarilia.ExibirMusicaDoAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
marilia.ExibirDiscografia();

