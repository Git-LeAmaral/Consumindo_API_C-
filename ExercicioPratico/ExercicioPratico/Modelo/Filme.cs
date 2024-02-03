

using System.Text.Json.Serialization;

namespace ExercicioPratico.Modelo;

internal class Filme
{
    [JsonPropertyName("title")]
    public string Nome { get; set; }

    [JsonPropertyName("year")]
    public string Ano { get; set; }

    [JsonPropertyName("crew")]
    public string Elenco { get; set; }

    [JsonPropertyName("imDbRating")]
    public string Avaliacao { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Filme: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Elenco: {Elenco}");
        Console.WriteLine($"Avaliação: {Avaliacao}");
    }
}
