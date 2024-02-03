

using System.Text.Json.Serialization;

namespace ExercicioPratico.Modelo;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string NomePais { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    
    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    public void ExibirInfoDoPais()
    {
        Console.WriteLine("======================");
        Console.WriteLine($"País: {NomePais}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"População: {Populacao}");
        Console.WriteLine($"Idioma: {Idioma}");
        Console.WriteLine("======================");
    }
}
