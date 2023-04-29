/*using Application.Core;
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

namespace Application.Count
{
    public class CountLike
    {
        public class Query : IRequest<Result<int>>
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
        public class Handler : IRequestHandler<Query, Result<int>>>
        {
            private readonly IConfiguration _configuration;
            public Handler(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            public async Task<Result<int>> Handle(Query request, CancellationToken cancellationToken)
            {
                string spName = "[USP_CountLuotThichCongThuc]";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDcongthuc", request.infor);
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<int>(new CommandDefinition(spName, parameters, commandType: System.Data.CommandType.StoredProcedure));
                    return Result<int>.Success(result);// compare of list  
                }
            }
        }
    }
}
*/