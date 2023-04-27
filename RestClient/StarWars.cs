using System.Text.Json.Serialization;
public class StarWars
{
    [JsonPropertyName("name")]
    public string name { get; set; }
}
