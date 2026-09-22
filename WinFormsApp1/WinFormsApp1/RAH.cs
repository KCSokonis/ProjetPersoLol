using System;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

public class RAH
{
    // The name of this class stands for : Riot API Handler, in short RAH.
    private static readonly HttpClient HttpClient;
    static RAH()
	{
    HttpClient = new HttpClient();
    HttpClient.BaseAddress = new Uri("https://europe.api.riotgames.com/riot/account/v1/");
    HttpClient.DefaultRequestHeaders.Add("X-Riot-Token","RGAPI-d18a76c5-1ae7-403b-a016-c288fb26aef5");
	}

    public async Task<string> GetByRiotID(string gameName, string tagName)
    {
        string url = "accounts/by-riot-id/"+gameName+"/"+tagName+"/";
        var json = await HttpClient.GetAsync(url);
        string informations = await json.Content.ReadAsStringAsync();
        return informations;
        

    }
}
