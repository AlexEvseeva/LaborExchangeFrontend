using System.ComponentModel.DataAnnotations;

namespace LaborExchange.Frontend.Models.Professions;

public class CreateProfession
{
    [Required] public string Name { get; set; }
}
