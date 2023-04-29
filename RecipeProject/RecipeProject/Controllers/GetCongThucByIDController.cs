
using Application.Core;
using Domain;
using HueCitApp.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeProject.Controllers
{
    public class GetCongThucByIDController : BaseApiController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GetCongThucByIDController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }

        [HttpGet("GetCongThucByID/{idCT?}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetCongThucByID(CancellationToken ct, int idCT)
        {

            var listResult = await Mediator.Send(new Application.CongThuc.GetCongThucByID.Query { infor = idCT }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }
    }
}
