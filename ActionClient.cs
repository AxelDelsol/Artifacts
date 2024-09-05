using Artifacts.Schemas;
using System.Configuration;
using System.Net.Http.Json;

namespace Artifacts;

internal class ActionClient(HttpClient client)
{
    public static ActionClient Create()
    {
        var client = new HttpClient()
        {
            BaseAddress = new Uri("https://api.artifactsmmo.com")
        };
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        client.DefaultRequestHeaders.Add("Authorization", $" Bearer {ConfigurationManager.AppSettings["token"]}");


        return new ActionClient(client);
    }

    public async Task<Move> move(string character, Position position)
    {
        using var response = await client.PostAsJsonAsync($"/my/{character}/action/move", position);
        response.EnsureSuccessStatusCode();

        var move = await response.Content.ReadBodyAsAsync<Root<Move>>();
        return move!.Data;
    }

    internal async Task<SkillData> Gather(string character)
    {
        using var response = await client.PostAsync($"/my/{character}/action/gathering", null);
        response.EnsureSuccessStatusCode();

        var gather = await response.Content.ReadBodyAsAsync<Root<SkillData>>()!;

        return gather!.Data;
    }

    private void waitFor(int cooldown_seconds)
    {
        for (int i = 1; i <= cooldown_seconds; i++)
        {
            Console.Write("\r");
            Console.Write($"Cooldown: {i}/{cooldown_seconds} secs");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
