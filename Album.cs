public class Album
{
    private List<Musica> musicas = new();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(mus => mus.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        System.Console.WriteLine($"Lista de músicas do album {Nome}");
        
        foreach(var item in musicas)
        {
            System.Console.WriteLine($"Música: {item.Nome}");
        }

        System.Console.WriteLine($"Duração total do album: {DuracaoTotal}.\n");
    }
}