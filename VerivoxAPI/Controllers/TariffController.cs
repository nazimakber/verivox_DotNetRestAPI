using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerivoxAPI.TariffData;

namespace VerivoxAPI.Controllers
{
    [ApiController]
    public class TariffController : ControllerBase
    {
        private ITariffData _tariffData;
        public TariffController(ITariffData tariffData)
        {
            _tariffData = tariffData;
        }
        
        [HttpGet]
        [Route("[controller]/{consumption}")]
        public IActionResult GetTariffs(Double consumption)
        {
            return Ok(_tariffData.GetTariff(consumption));
        }


    }
}
