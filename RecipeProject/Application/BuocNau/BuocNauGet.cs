using Application.Core;
using Dapper;
using Domain;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.BuocNau
{
    public class BuocNauGet
    {
        public class Query : IRequest<Result<List<Table_BuocNau>>>
        {// su li tham so dau vao
            public int infor { get; set; }
        }
        public class CommandValidator : AbstractValidator<int>
        {
            public CommandValidator()
            {
                RuleFor(x => x).NotEmpty().NotNull(); 
            }
        }
        public class Handler : IRequestHandler<Query, Result<List<Table_BuocNau>>>
        {
            private readonly IConfiguration _configuration;
            public Handler(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            public async Task<Result<List<Table_BuocNau>>> Handle(Query request, CancellationToken cancellationToken)
            {
                string spName = "USP_DSBuocNauGets";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDCongThuc", request.infor);
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<Table_BuocNau>(new CommandDefinition(spName,parameters, commandType: System.Data.CommandType.StoredProcedure));
                    return Result<List<Table_BuocNau>>.Success(result.ToList());// compare of list  

                }

            }
        }
    }
}
