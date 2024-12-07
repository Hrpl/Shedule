using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Domain.Entities;

public class Group : BaseEntity
{
    public int Number {  get; set; }
    public int TeacherId { get; set; }
}
