using LaborExchange.Frontend.Models.Vacancies;

namespace LaborExchange.Frontend;

public static class VacancyMapping
{
    public static CreateVacancy toCreateDto(this Vacancy vacancy) =>
    new CreateVacancy{
        FirmName = vacancy.FirmName,
        ProfessionId = vacancy.Position.Id,
        WorkingCondition = vacancy.WorkingCondition,
        Payment = vacancy.Payment,
        LivingCondition = vacancy.LivingCondition,
        Requirements = vacancy.Requirements,
        IsArchived = vacancy.IsArchived,
        Contacts = vacancy.Contacts,
    };

    public static UpdateVacancy toUpdateDto(this CreateVacancy vacancy, int id) =>
    new UpdateVacancy{
        Id = id,
        FirmName = vacancy.FirmName,
        ProfessionId = vacancy.ProfessionId,
        WorkingCondition = vacancy.WorkingCondition,
        Payment = vacancy.Payment,
        LivingCondition = vacancy.LivingCondition,
        Requirements = vacancy.Requirements,
        Contacts = vacancy.Contacts,
        IsArchived = vacancy.IsArchived
    };
     public static UpdateVacancy toUpdateDto(this Vacancy vacancy, int id) =>
        new UpdateVacancy{
            Id = id,
            FirmName = vacancy.FirmName,
            ProfessionId = vacancy.Position.Id,
            WorkingCondition = vacancy.WorkingCondition,
            Payment = vacancy.Payment,
            LivingCondition = vacancy.LivingCondition,
            Requirements = vacancy.Requirements,
            Contacts = vacancy.Contacts,
            IsArchived = vacancy.IsArchived
        };

}
