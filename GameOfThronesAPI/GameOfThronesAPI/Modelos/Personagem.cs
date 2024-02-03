

using System.Text.Json.Serialization;

namespace GameOfThronesAPI.Modelos;

internal class Personagem
{
    [JsonPropertyName("name")]
    public string NomePersonagem { get; set; }

    [JsonPropertyName("gender")]
    public string Genero { get; set; }

    [JsonPropertyName("culture")]
    public string Civilizacao { get; set; }

    [JsonPropertyName("born")]
    public string Nascimento { get; set; }

    [JsonPropertyName("aliases")]
    public List<string>? Apelido { get; set; }

    public void ExibirDadosDoPersonagem()
    {
        Console.WriteLine("====== FICHA DO PERSONAGEM ======");
        Console.WriteLine($"Nome: {NomePersonagem}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Civilização: {Civilizacao}");
        Console.WriteLine($"Nasceu em: {Nascimento}");

        foreach (string apelido in Apelido)
        {
            Console.WriteLine($"Apelido: {apelido}");
        }
        Console.WriteLine("===============================");
    }
}
