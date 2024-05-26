﻿using System.ComponentModel.DataAnnotations;

namespace LaborExchange.Frontend;

public class CreateVacancy
{
    [Required] public string FirmName { get; set; }
    [Required] public Profession Position { get; set; }
    public string? WorkingCondition { get; set; }
    [Range(0, 120_000_000)] public decimal Payment { get; set; }
    public string? LivingCondition { get; set; }
    [Required] public string Requirements { get; set; }
}
