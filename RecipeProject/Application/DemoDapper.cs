﻿using Application.Core;
using Dapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class DemoDapper
    {
        //public class Query : IRequest<Result<List<HoSoLuTruItemResponse>>>
        //{
        //    public Distance_Request infor { get; set; }

        //}
        //public class CommandValidator : AbstractValidator<Distance_Request>
        //{
        //    public CommandValidator()
        //    {
        //        RuleFor(x => x.x).NotEmpty().NotNull();
        //        RuleFor(x => x.y).NotEmpty().NotNull();




        //    }
        //}
        //public class Handler : IRequestHandler<Query, Result<List<HoSoLuTruItemResponse>>>
        //{
        //    private readonly IConfiguration _configuration;

        //    public Handler(IConfiguration configuration)
        //    {
        //        _configuration = configuration;

        //    }
        //    public async Task<Result<List<HoSoLuTruItemResponse>>> Handle(Query request, CancellationToken cancellationToken)
        //    {
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@PPAGEINDEX", request.infor.pageindex);
        //        parameters.Add("@PPAGESIZE", request.infor.pagesize);
        //        parameters.Add("@X", request.infor.x);
        //        parameters.Add("@Y", request.infor.y);
        //        parameters.Add("@Distance", request.infor.distance);
        //        string spName = "SP_DSDistanceToCoSoLuuTru";
        //        using (var connection = new SqlConnection(_configuration.GetConnectionString("HuecitConnection")))
        //        {
        //            connection.Open();
        //            //var result = await connection.QueryAsync<Place>(spName);
        //            var result = await connection.QueryAsync<HoSoLuTruItemResponse>(new CommandDefinition(spName, parameters, commandType: System.Data.CommandType.StoredProcedure));
        //            return Result<List<HoSoLuTruItemResponse>>.Success(result.ToList());
        //        }
        //    }
        //}
    }
}
