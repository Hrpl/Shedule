using Shedule.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Infrastructure.Services.Interfaces;

public interface IEmployeeRepository
{
    public Task CreateEmployeeAsync(EmployeeModel model);
}
