Banda bbhmm = new($"Rihanna");

Album albumDaRiri = new($"Bitch Better Have My Money");

Musica musica1 = new(bbhmm, "Bitch better have my money.")
{
    Duracao = 200,
    Disponivel = true,
};

Musica musica2 = new(bbhmm, "Rude boy.")
{
    Duracao = 213,
    Disponivel = false,
};

albumDaRiri.AdicionarMusica(musica1);
albumDaRiri.AdicionarMusica(musica2);
bbhmm.AdicionarAlbum(albumDaRiri);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDaRiri.ExibirMusicasDoAlbum();
bbhmm.ExibirDiscografia();


Podcast pod1 = new("Para dar nome às coisas", "Nat");
Podcast pod2 = new("Não inviabilize", "Déia Freitas");
Podcast pod3 = new("Mano a mano", "Mano Brown");

Episodio ep1 = new(1, "O mistério de cada dia.", 45);
Episodio ep2 = new(2, "Carma.", 50);
Episodio ep3 = new(3, "Piso.", 55);
Episodio ep4 = new(4, "Sueli Carneiro.", 60);
Episodio ep5 = new(5, "Silvio Almeida.", 43);
Episodio ep6 = new(6, "Seu Jorge.", 40);

ep6.AdicionarConvidados("Jeferson De");

pod1.AdicionarEpisodio(ep1);
pod1.ExibirDetalhes();
//System.Console.WriteLine(ep1.Resumo);

pod2.AdicionarEpisodio(ep2);
pod2.AdicionarEpisodio(ep3);
pod2.ExibirDetalhes();
//System.Console.WriteLine(ep3.Resumo);

pod3.AdicionarEpisodio(ep4);
pod3.AdicionarEpisodio(ep5);
pod3.AdicionarEpisodio(ep6);
pod3.ExibirDetalhes();
//System.Console.WriteLine(ep6.Resumo);