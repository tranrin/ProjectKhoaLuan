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
    public class GetCongThucController : BaseApiController
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        private readonly IWebHostEnvironment _webHostEnvironment;
        public GetCongThucController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }
        [HttpGet("GetCongThucbyCountry/{idcategory?}")]
        [AllowAnonymous]

        public async Task<IActionResult> GetCongThucbyCountry(CancellationToken ct, int idcategory)
        {

            var listResult = await Mediator.Send(new Application.CongThuc.GetCongThucbyCountry.Query { infor = idcategory }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }


        

    }
}
