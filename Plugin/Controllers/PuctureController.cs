using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plugin.Abstraction;
using Plugin.Models;

namespace Plugin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuctureController : ControllerBase
    {
        private readonly ICommonService _service;
        public PuctureController(ICommonService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult<byte[]>> Modify([FromBody] byte[] picture, [FromBody] ModificationModel model)
        {
            return await _service.Modify(picture, model);
        }
    }
}