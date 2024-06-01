using System.ComponentModel.DataAnnotations;

namespace LaborExchange.Frontend.Models.Professions;

public class Profession
{
    [Required] public int Id { get; set; }
    [Required] public string Name { get; set; }
}
