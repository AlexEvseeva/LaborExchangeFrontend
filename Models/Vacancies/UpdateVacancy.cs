﻿using System.ComponentModel.DataAnnotations;

namespace LaborExchange.Frontend.Models.Vacancies;

public class UpdateVacancy
{
    [Required] public int Id { get; set; }
    [Required] public string FirmName { get; set; }
    [Required] public int ProfessionId { get; set; }
    public string? WorkingCondition { get; set; }
    [Range(0, 120_000_000)] public decimal? Payment { get; set; }
    public string? LivingCondition { get; set; }
    [Required] public string Requirements { get; set; }
    public string Contacts { get; set; }
    public bool IsArchived { get; set; }
}
