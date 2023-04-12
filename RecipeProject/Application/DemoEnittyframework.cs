using Application.Core;
using MediatR;
using Microsoft.Extensions.Configuration;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class DemoEnittyframework
    {

            //public class Query : IRequest<Result<List<Domain.Activity>>>
            //{

            //}

            //public class Handler : IRequestHandler<Query, Result<List<Domain.Activity>>>
            //{
            //    private readonly IConfiguration _configuration;
            //    private readonly DataContext _context;

            //    public Handler(DataContext context, IConfiguration configuration)
            //    {
            //        _context = context;
            //        _configuration = configuration;

            //    }

            //    public async Task<Result<List<Domain.Activity>>> Handle(Query request, CancellationToken cancellationToken)
            //    {
            //        var lstResult = await _context.Activities.ToListAsync<Domain.Activity>();

            //        return Result<List<Domain.Activity>>.Success(lstResult);
            //    }
            //}
        
    }
}
