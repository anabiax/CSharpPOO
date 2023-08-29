public class Podcast
{
    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> episodios = new();
    public int TotalEpisodios => episodios.Count;

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"\nPodcast {Nome} apresentado por {Host}.");
        
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine(episodio.Resumo);
        }

        System.Console.WriteLine($"Total de episódios: {TotalEpisodios}.");
    }
}