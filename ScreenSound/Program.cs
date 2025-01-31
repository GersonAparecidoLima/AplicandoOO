//Album albumDoFernandinho = new Album();
//albumDoFernandinho.Nome = "Faz Chover";

//Musica musica1 = new Musica();
//musica1.Nome = "Uma nova Historia";
//musica1.Duracao = 213;

//Musica musica2 = new Musica();
//musica2.Nome = "Pequena nuvem";
//musica2.Duracao = 354;

//albumDoFernandinho.AdicionarMusica(musica1);
//albumDoFernandinho.AdicionarMusica(musica2);


Album albumDoFernandinho = new Album();
albumDoFernandinho.Nome = "Faz Chover";

Musica musica1 = new Musica();
musica1.Nome = "Uma nova Historia";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Pequena nuvem";
musica2.Duracao = 354;

albumDoFernandinho.AdicionarMusica(musica1);
albumDoFernandinho.AdicionarMusica(musica2);

albumDoFernandinho.ExibirMusicasDoAlbum();

// Manter o console aberto após a execução
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadLine();