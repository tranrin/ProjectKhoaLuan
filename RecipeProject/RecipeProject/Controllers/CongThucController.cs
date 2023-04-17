using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongThucController : ControllerBase
    {
        public static List<Table_CongThuc> congthucs = new List<Table_CongThuc>();
        // Lấy Công thức theo Id
        [HttpGet ("{idcongthuc}")]
        public IActionResult GetCongThucbyId(int id)
        {
            try
            {
                var congThuc = congthucs.SingleOrDefault(ct => ct.ID == id);
                if(congThuc==null)
                {
                    return NotFound();
                }
                return Ok(congThuc);
            }
            catch
            {
                return BadRequest();
            }
        }

        // Update công thức :
        [HttpPut("{idcongthuc}")]
        public IActionResult UpdateCongThuc(int id, string TenCongThuc, string MoTa, int ThoiGianNau,int IdUser, int IdCountry)
        {
            try
            {
                var congThuc = congthucs.SingleOrDefault(ct => ct.ID == id);
                if (congThuc == null)
                {
                    return NotFound();
                }
                else
                {
                    congThuc.TenCongThuc = TenCongThuc;
                    congThuc.MoTa = MoTa;
                    congThuc.ThoiGianNau = ThoiGianNau;
                    congThuc.IDUser = IdUser;
                    congThuc.IDCountry = IdCountry;
                }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // Thêm công thức
        [HttpPost]
        public IActionResult CreateCongThuc(Table_CongThuc congthucadd)
        {
            var congthuc = new Table_CongThuc
            {
                TenCongThuc = congthucadd.TenCongThuc,
                MoTa = congthucadd.MoTa,
                ThoiGianNau = congthucadd.ThoiGianNau,
                IDUser = congthucadd.IDUser,
                IDCountry = congthucadd.IDCountry
            };
            congthucs.Add(congthuc);
            return Ok(
                new
                {
                    Success = true,
                    Data = congthuc
                }
                );
        }

        //XÓa công thức:
        [HttpDelete("id")]
        public IActionResult DeleteCongThuc(int id)
        {
            try
            {
                var congThuc = congthucs.SingleOrDefault(ct => ct.ID == id);
                if (congThuc == null)
                {
                    return NotFound();
                }
                congthucs.Remove(congThuc);
                
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
