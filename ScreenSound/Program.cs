Banda fernadinho = new Banda("Fernandinho");

Album albumDoFernadinho = new Album("Faz chover");

Musica musica1 = new Musica(fernadinho, "pequena nuvel")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(fernadinho, "Uma nova  historia")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoFernadinho.AdicionarMusica(musica1);
albumDoFernadinho.AdicionarMusica(musica2);
fernadinho.AdicionarAlbum(albumDoFernadinho);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoFernadinho.ExibirMusicasDoAlbum();
fernadinho.ExibirDiscografia();
