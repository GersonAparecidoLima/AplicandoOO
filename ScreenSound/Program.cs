//Banda fernadinho = new Banda("Fernandinho");

//Album albumDoFernadinho = new Album("Faz chover");

//Musica musica1 = new Musica(fernadinho, "pequena nuvel")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(fernadinho, "Uma nova  historia")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoFernadinho.AdicionarMusica(musica1);
//albumDoFernadinho.AdicionarMusica(musica2);
//fernadinho.AdicionarAlbum(albumDoFernadinho);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoFernadinho.ExibirMusicasDoAlbum();
//fernadinho.ExibirDiscografia();

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidado("Ana Pereira");
ep1.AdicionarConvidado("Mário Francis");

Episodio ep2 = new(2, "Aprendendo a aprender", 78);
ep2.AdicionarConvidado("Marcos Felício");

Episodio ep3 = new(3, "Consciênciologia", 87);
ep3.AdicionarConvidado("Flavio Almeida");
ep3.AdicionarConvidado("Gui Lima");
ep3.AdicionarConvidado("Fernanda Fernandes");

Episodio ep0 = new(1, "Filosofia de software", 93);
ep0.AdicionarConvidado("Fernando Roberto");
ep0.AdicionarConvidado("Gabriel Barbosa");

Podcast podcast = new("TI para Poucos", "Daniel Portugal");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep0);

podcast.ExibirDetalhes();