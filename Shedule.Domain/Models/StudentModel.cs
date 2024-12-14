using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Domain.Models;

public class StudentModel
{
    public int GroupId { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
    public bool? IsDeleted { get; set; } = false;
}
