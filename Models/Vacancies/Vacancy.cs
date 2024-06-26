﻿using LaborExchange.Frontend.Models.Professions;

namespace LaborExchange.Frontend.Models.Vacancies;

public class Vacancy
{
    public int Id { get; set; }
    public string FirmName { get; set; }
    public Profession Position { get; set; }
    public string? WorkingCondition { get; set; }
    public decimal Payment { get; set; }
    public string? LivingCondition { get; set; }
    public string Requirements { get; set; }
    public string Contacts { get; set; }
    public bool IsArchived { get; set; }
    public bool? IsSelected { get; set; }
}
