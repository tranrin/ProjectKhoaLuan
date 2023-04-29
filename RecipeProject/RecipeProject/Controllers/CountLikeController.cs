/*
using Application.Core;
using Domain;
using HueCitApp.Controllers;
using MediatR;
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
    public class CountLikeController : BaseApiController
    {
        *//* public IActionResult Index()
         {
             return View();
         }*//*
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CountLikeController(IWebHostEnvironment hostingEnvironment) : base(hostingEnvironment)
        {
            _webHostEnvironment = hostingEnvironment;
        }
        [HttpGet("CountLikeController/{idcongthuc?}")]
        [AllowAnonymous]

        public async Task<IActionResult> CountLike(CancellationToken ct, int idcongthuc)
        {

            var listResult = await Mediator.Send(new Application.Count.CountLike.Query { infor = idcongthuc }, ct);
            //return HandlerResult(listResult);
            return HandlerResult(listResult);
        }
    }
}
*/