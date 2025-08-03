using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Bichinho
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public string Habilidade { get; set; }
}

class Program
{
    static List<Bichinho> CarregarBichinhos(string caminho)
    {
        string json = File.ReadAllText(caminho);
        return JsonSerializer.Deserialize<List<Bichinho>>(json);
    }

    static void Main()
    {
        var bichinhos = CarregarBichinhos("bichinho.json");

        Console.WriteLine("Bichinhos disponíveis na loja:");
        foreach (var b in bichinhos)
        {
            Console.WriteLine($"{b.Nome} - ATK: {b.Ataque} / HP: {b.Vida} - Habilidade: {b.Habilidade}");
        }
    }
}

