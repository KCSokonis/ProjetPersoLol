using Opggessaye;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

public class RiotApiHandler
{
    // The name of this class stands for : Riot API Handler, in short RAH.
    private static readonly HttpClient HttpClient;
    static RiotApiHandler()
    {
        HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-d18a76c5-1ae7-403b-a016-c288fb26aef5");
    }

    //This class uses a RiotAccount object and retrieves his puuid while also confirming the player exists within Riot Data Base.
    public async Task<RiotAccount> GetByRiotID(String gameName, String tagName)
    {

        string url = "https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/" + gameName + "/" + tagName + "/";
        using (HttpResponseMessage awnser = await HttpClient.GetAsync(url))
        {
            string Response = await awnser.Content.ReadAsStringAsync();
            if (awnser.IsSuccessStatusCode)
            {
                RiotAccount? account = JsonSerializer.Deserialize<RiotAccount>(Response);

                return account;
            }
            else if (awnser.StatusCode == HttpStatusCode.NotFound)
            {
                throw new KeyNotFoundException($"Le joueur {gameName}#{tagName} est introuvable.");

            }
            else
            {
                throw new HttpRequestException($"Erreur lors de l'appel à l'API Riot. Code HTTP : {(int)awnser.StatusCode}");
            }


        }
    }
    public async Task<List<ChampionMasteries>> GetMasteries(RiotAccount account)
    {
        string url = $"https://euw1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-puuid/{account.puuid}/top?count=5";
        using (HttpResponseMessage awnser = await HttpClient.GetAsync(url))
        {
            string Response = await awnser.Content.ReadAsStringAsync();
            if (awnser.IsSuccessStatusCode)
            {
                List<ChampionMasteries>? result = JsonSerializer.Deserialize<List<ChampionMasteries>>(Response);

                return result;
            }
            else
            {
                throw new HttpRequestException($"Erreur lors de l'appel à l'API Riot. Code HTTP : {(int)awnser.StatusCode}");
            }


        }
    }
    public List<String> ShowMasteries(List<ChampionMasteries> MasteriesInformation)
    {
                List<String> masteries = new List<string>();
                foreach(ChampionMasteries Champ in MasteriesInformation)
                {
                    masteries.Add($"- {Champ.championName}\nNiveau : {Champ.championLevel}\nPoints totaux de maitrise: {Champ.championPoints}\n");
                }

                return masteries;
        }
    
}
