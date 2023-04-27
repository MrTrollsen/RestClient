using RestSharp;
using System.Text.Json;

bool success = false;

while (success == false)
{
Console.WriteLine("StarWars character creation game:");
Console.WriteLine("type a number to choose which StarWars character you are going to play as.");
string StarWarsCharacter = Console.ReadLine();

RestClient StarWarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("people/" + StarWarsCharacter);
RestResponse respons = StarWarsClient.GetAsync(request).Result;

Console.Clear();

if (respons.StatusCode.ToString() == "OK")
{
 StarWars j = JsonSerializer.Deserialize<StarWars>(respons.Content);
 Console.WriteLine("Chosen Character" + " = " + j.name);
 success = true;
}
else
{
 Console.WriteLine("The number" + StarWarsCharacter + " does not correspond to any character in StarWars.");
 Console.WriteLine("Try another number.");
 Console.WriteLine("");
 success = false;
}
}
Console.WriteLine("Press enter to exit");
Console.ReadLine();




