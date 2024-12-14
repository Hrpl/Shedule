using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Domain.Models;

public class UserModel
{
    public string Login { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
    public bool? IsDeleted { get; set; } = false;
}
