namespace LaborExchange.Frontend;

public class ResumeClient(HttpClient httpClient)
{
    const string endpointName = "resume";
    public async Task<List<Resume>> GetResumeAsync() =>
        await httpClient.GetFromJsonAsync<List<Resume>>(endpointName) ?? [];

    public async Task<Resume> GetResumeById(int id) =>
        await httpClient.GetFromJsonAsync<Resume>($"{endpointName}/{id}")
            ?? throw new Exception($"resume with id: {id} not found!");

    public async Task AddResumeAsync(CreateResume resume) =>
        await httpClient.PostAsJsonAsync(endpointName, resume);

    public async Task UpdateResumeAsync(UpdateResume resume, int id) =>
        await httpClient.PutAsJsonAsync($"{endpointName}/{id}", resume);

    public async Task DeleteResumeAsync(int id) =>
        await httpClient.DeleteAsync($"{endpointName}/{id}");
}