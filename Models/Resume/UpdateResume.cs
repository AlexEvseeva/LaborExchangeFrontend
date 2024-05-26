namespace LaborExchange.Frontend.Models.Resume;

public class UpdateResume
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ProfessionId { get; set; }
    public string? Education { get; set; }
    public string? LastPositionFirm { get; set; }
    public string? LastPositionName { get; set; }
    public string? ReasonOfDismissal { get; set; }
    public string? MartialStatus { get; set; }
    public string? LivingCondition { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Requirements { get; set; }

}
