using ScreenSoundApi.Modelos;
using System.Text.Json;
using ScreenSoundApi.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //Console.WriteLine(musicas.Count);
        //musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}

//https://www.cheapshark.com/api/1.0/deals"

// 2.Escrever um programa que solicite dois números a e b
// lidos do teclado e realize a divisão de a por b. Caso
// essa operação não seja possível, mostrar uma mensagem
// no console que deixe claro o erro ocorrido.


// ===========USANDO CASTING===============
/*try
{
    Console.Write("Digite o numerador: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;
    Console.WriteLine($"RESULTADO: {resultado}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
}*/


// 3.Declarar uma lista de inteiros e tente acessar um elemento
// em um índice inexistente. Tratar a exceção apropriada.

/*try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}*/


// 4.Criar uma classe simples com um método e chame esse método em um
// objeto nulo. Tratar a exceção de método em objeto nulo.


/*try
{
    for (int i = 3; i >= 0; i--)
    {
        Console.WriteLine($"{10 / i}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Tivemos um problema: {ex.Message}");
}*/
