public class Musica 
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public int Lancamento { get; set; }
    public Genero Genero { get; set; }

    // prop somente leitura
    public string Descricao => $"A música {Nome} composta pela artista {Artista} foi lançada em {Lancamento}."; 

    public Musica(Banda artista, string nome){
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista.Nome}");
        System.Console.WriteLine($"Duracao: {Duracao}");

        if(Disponivel)
        {
            System.Console.WriteLine($"Disponível no plano.\n");
        }

        System.Console.WriteLine($"Não está disponível no seu plano. Adquira o premium.\n");
    }
}