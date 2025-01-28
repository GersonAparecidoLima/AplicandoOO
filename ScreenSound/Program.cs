Musica musica1 = new Musica();
musica1.Nome = "Faz Chover";
musica1.Artista = "Fernando";
musica1.Duracao = 273;
musica1.Disponivel =  true;
Console.WriteLine(musica1.DescricaoResumida);




Musica musica2 = new Musica();
musica2.Nome = "Com muito louvor";
musica2.Artista = "Casiane";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);

/*
Console.WriteLine($"Nome da música : {musica1.nome}");
Console.WriteLine($"Nome da música : {musica1.artista}");
Console.WriteLine($"Nome da música : {musica2.nome}");
Console.WriteLine($"Nome da música : {musica2.artista}");
*/

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
