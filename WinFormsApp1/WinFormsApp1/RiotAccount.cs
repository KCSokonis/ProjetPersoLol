using System;
using System.Text.Json.Serialization;
public class RiotAccount
{
    [JsonPropertyName("puuid")]
    public string puuid { get; set; } = string.Empty;

    [JsonPropertyName("gameName")]
    public string gameName { get; set; } = string.Empty;

    [JsonPropertyName("tagLine")]
    public string tagName { get; set; } = string.Empty;
    public RiotAccount()
    {}
    public RiotAccount(String gameName, String tagName )
	{
		this.gameName = gameName;
		this.tagName = tagName;
	}
    public RiotAccount(String gameName, String tagName,String puuid)
    {
        this.gameName = gameName;
        this.tagName = tagName;
        this.puuid = puuid;
    }

}
