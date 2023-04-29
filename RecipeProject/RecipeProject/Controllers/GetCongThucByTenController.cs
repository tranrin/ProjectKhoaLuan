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
    public class GetCongThucByTenController : BaseApiController
    {
        /* public IActionResult Index()
         {
             return View();
         }*/

        private readonly IWebHostEnvironment _webHostEnvironment;
        public GetCongThucByTenController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }
        [HttpGet("GetCongThucByTen/{tenCT?}")]
        [AllowAnonymous]

        public async Task<IActionResult> GetCongThucByTen(CancellationToken ct, string tenCT)
        {

            var listResult = await Mediator.Send(new Application.CongThuc.GetCongThucByTen.Query { infor = tenCT }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }
    }
}
