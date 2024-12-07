
namespace Shedule.Domain.Entities;

public class Time : BaseEntity
{
    public int Number {  get; set; }
    public int Day { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

}
