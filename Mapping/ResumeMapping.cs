using LaborExchange.Frontend.Models.Resume;

namespace LaborExchange.Frontend;

public static class ResumeMapping
{
    public static CreateResume toCreateDto(this Resume resume) =>
        new CreateResume{
            FirstName = resume.FirstName,
            LastName = resume.LastName,
            ProfessionId = resume.Profession.Id,
            Education = resume.Education,
            LastPositionFirm = resume.LastPositionFirm,
            LastPositionName = resume.LastPositionName,
            ReasonOfDismissal = resume.ReasonOfDismissal,
            MartialStatus = resume.MartialStatus,
            LivingCondition = resume.LivingCondition,
            Email = resume.Email,
            Phone = resume.Phone,
            Requirements = resume.Requirements,
            DateOfBirth = resume.DateOfBirth,
        };

    public static UpdateResume toUpdateDto(this CreateResume resume, int id) =>
        new UpdateResume{
            Id = id,
            FirstName = resume.FirstName,
            LastName = resume.LastName,
            ProfessionId = resume.ProfessionId,
            Education = resume.Education,
            LastPositionFirm = resume.LastPositionFirm,
            LastPositionName = resume.LastPositionName,
            ReasonOfDismissal = resume.ReasonOfDismissal,
            MartialStatus = resume.MartialStatus,
            LivingCondition = resume.LivingCondition,
            Email = resume.Email,
            Phone = resume.Phone,
            Requirements = resume.Requirements,
            DateOfBirth = resume.DateOfBirth,
        };
}
