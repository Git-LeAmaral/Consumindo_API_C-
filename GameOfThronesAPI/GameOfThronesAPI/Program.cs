using GameOfThronesAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/685");
        //Console.WriteLine(resposta);

        Personagem personagem = JsonSerializer.Deserialize<Personagem>(resposta)!;
        personagem.ExibirDadosDoPersonagem();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Opps! Tem algo errado: {ex.Message}");
    }
}