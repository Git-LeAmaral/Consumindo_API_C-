using ExercicioPratico.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        //Console.WriteLine(resposta);

        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta);
        filmes[2].ExibirDetalhesDoFilme();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos um problema: {ex.Message}");
    }

    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");

        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        paises[1].ExibirInfoDoPais();
        //Console.WriteLine(paises.Count);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Tivemos um problema: {ex.Message}");
    }

    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");

        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        carros[3].ExibirInfoDoCarro();
        Console.WriteLine($"Exitem na lista: {carros.Count} veiculos");
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Tivemos um problema: {ex.Message}");
    }
}