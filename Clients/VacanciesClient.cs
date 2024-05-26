namespace LaborExchange.Frontend;

public class VacanciesClient (HttpClient httpClient)
{
    const string endpointName = "vacancies";
    public async Task<List<Vacancy>> GetVacanciesAsync () => await httpClient.GetFromJsonAsync<List<Vacancy>>(endpointName) ?? [];

    
}
