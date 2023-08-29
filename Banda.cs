public class Banda
{
    private List<Album> albumBanda = new();
    public string Nome { get; }

    public Banda(string nome)
    {
        Nome = nome;
    }
    
    public void AdicionarAlbum(Album album)
    {
        albumBanda.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da {Nome}.");
        
        foreach(var item in albumBanda)
        {
            System.Console.WriteLine($"Album: {item.Nome} cuja duração total é {item.DuracaoTotal}");
        }
    }
}