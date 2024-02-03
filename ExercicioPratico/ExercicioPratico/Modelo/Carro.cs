

using System.Text.Json.Serialization;

namespace ExercicioPratico.Modelo;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("motor")]
    public string Motor { get; set; }


    public void ExibirInfoDoCarro()
    {
        Console.WriteLine("");
        Console.WriteLine("==================");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Motor: {Motor}");
        Console.WriteLine("==================");
    }
}
