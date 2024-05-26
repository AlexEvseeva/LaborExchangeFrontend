namespace LaborExchange.Frontend.Clients;

public class VacanciesClient(HttpClient httpClient)
{
    const string endpointName = "vacancies";
    public async Task<List<Vacancy>> GetVacanciesAsync() =>
        await httpClient.GetFromJsonAsync<List<Vacancy>>(endpointName) ?? [];

    public async Task<Vacancy> GetVacancyById(int id) =>
        await httpClient.GetFromJsonAsync<Vacancy>($"{endpointName}/{id}")
            ?? throw new Exception($"Vacancy with id: {id} not found!");

    public async Task AddVacancyAsync(CreateVacancy vacancy) =>
        await httpClient.PostAsJsonAsync(endpointName, vacancy);

    public async Task UpdateVacancyAsync(UpdateVacancy vacancy, int id) =>
        await httpClient.PutAsJsonAsync($"{endpointName}/{id}", vacancy);

    public async Task DeleteVacancyAsync(int id) =>
        await httpClient.DeleteAsync($"{endpointName}/{id}");
}
