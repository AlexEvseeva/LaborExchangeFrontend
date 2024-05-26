namespace LaborExchange.Frontend;

public class ProfessionsClient(HttpClient httpClient)
{
    const string endpointName = "professions";
    public async Task<List<Profession>> GetProfessionsAsync() =>
        await httpClient.GetFromJsonAsync<List<Profession>>(endpointName) ?? [];
}
