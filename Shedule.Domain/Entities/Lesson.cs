namespace Shedule.Domain.Entities;

public class Lesson : BaseEntity
{
    public int TimeId { get; set; }
    public int TeacherId { get; set; }
    public int DisciplineId { get; set; }
    public int GroupId { get; set; }
}
