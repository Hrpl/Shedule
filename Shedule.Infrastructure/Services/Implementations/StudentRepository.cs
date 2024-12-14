using Shedule.Domain.Models;
using Shedule.Infrastructure.Services.Interfaces;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Infrastructure.Services.Implementations;

public class StudentRepository : IStudentRepository
{
    private readonly QueryFactory _queryFactory;
    private const string TableName = "Employees";
    public StudentRepository(IDbConnectionManager dbConnectionManager)
    {
        _queryFactory = dbConnectionManager.PostgresQueryFactory;
    }


    public async Task CreateStudentAsync(StudentModel model)
    {
        var query = _queryFactory.Query(TableName)
            .AsInsert(model);

        await _queryFactory.ExecuteAsync(query);
    }
}
