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

namespace Application.CongThuc
{
    public class GetCongThucbyCountry
    {
        public class Query : IRequest<Result<List<CongThuc_Img>>>
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
        public class Handler : IRequestHandler<Query, Result<List<CongThuc_Img>>>
        {
            private readonly IConfiguration _configuration;
            public Handler(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            public async Task<Result<List<CongThuc_Img>>> Handle(Query request, CancellationToken cancellationToken)
            {
                string spName = "USP_GetCongThucByCountry";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDCountry", request.infor);
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<CongThuc_Img>(new CommandDefinition(spName, parameters, commandType: System.Data.CommandType.StoredProcedure));
                    return Result<List<CongThuc_Img>>.Success(result.ToList());// compare of list  
                }
            }
        }
    }
}
