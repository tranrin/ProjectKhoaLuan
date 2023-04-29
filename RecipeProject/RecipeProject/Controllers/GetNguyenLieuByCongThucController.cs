
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
    public class GetNguyenLieuByCongThucController : BaseApiController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GetNguyenLieuByCongThucController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }
        [HttpGet("GetNguyenLieubyCongThuc/{idcongthuc?}")]
        [AllowAnonymous]

        public async Task<IActionResult> GetNguyenLieubyCongThuc(CancellationToken ct, int idcongthuc)
        {

            var listResult = await Mediator.Send(new Application.NguyenLieu.GetNguyenLieuByCongThuc.Query { infor = idcongthuc }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }
    }
}
