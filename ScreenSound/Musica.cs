//Criando uma classe
class Musica
{
    //Construtor ( ele não tem retorno, o nome dele é o tipo)
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
public string Nome { get; } //set(escreve)...get(lê)
public Banda Artista { get; }
public int Duracao { get; set; }
public bool Disponivel { get; set; } 

//Criando propriedade Ce. tralizando acesso ( proteger a escrita ) usando get e set
public string DescricaoResumida =>
 $"A música {Nome} pertene à banda {Artista}";

//Metodo
public void ExibirFichaTecnica()
{
    Console.WriteLine($"\nNome: {Nome}");
    Console.WriteLine($"Artista: {Artista.Nome}");
    Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
        Console.WriteLine("Disponivel no plano");
    } else
    {
        Console.WriteLine("Adquira o plano Plus+.");
    }
}
}

