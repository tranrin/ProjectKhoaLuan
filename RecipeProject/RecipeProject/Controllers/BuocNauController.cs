
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
    public class BuocNauController : BaseApiController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BuocNauController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }
        [HttpGet("BuocNauGet/{idcongthuc?}")]
        [AllowAnonymous]

        public async Task<IActionResult> BuocNauGet(CancellationToken ct, int idcongthuc)
        {

             var listResult = await Mediator.Send(new Application.BuocNau.BuocNauGet.Query {infor = idcongthuc }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }
    }
}
