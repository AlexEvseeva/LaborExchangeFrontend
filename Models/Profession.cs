using System.ComponentModel.DataAnnotations;

namespace LaborExchange.Frontend;

public class Profession
{
    [Required] public int Id { get; set; }
    [Required] public string Name { get; set; }
}
