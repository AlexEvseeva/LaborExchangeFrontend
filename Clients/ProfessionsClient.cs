namespace LaborExchange.Frontend.Clients;
using LaborExchange.Frontend.Models.Professions;

public class ProfessionsClient(HttpClient httpClient)
{
    const string endpointName = "professions";
    public async Task<List<Profession>> GetProfessionsAsync() =>
        await httpClient.GetFromJsonAsync<List<Profession>>(endpointName) ?? [];

    public async Task CreateProfession(CreateProfession newProf) =>
        await httpClient.PostAsJsonAsync(endpointName, newProf);
}
