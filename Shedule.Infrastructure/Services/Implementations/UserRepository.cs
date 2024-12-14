using Shedule.Domain.Models;
using Shedule.Infrastructure.Services.Interfaces;
using SqlKata;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shedule.Infrastructure.Services.Implementations;

public class UserRepository : IUserRepository
{
    private readonly QueryFactory _queryFactory;
    private const string TableName = "Users";
    public UserRepository(IDbConnectionManager dbConnectionManager)
    {
        _queryFactory = dbConnectionManager.PostgresQueryFactory;
    }

    public async Task CreateUserAsync(UserModel model)
    {
        var query = _queryFactory.Query(TableName)
            .AsInsert(model);

        await _queryFactory.ExecuteAsync(query);
    }
}
