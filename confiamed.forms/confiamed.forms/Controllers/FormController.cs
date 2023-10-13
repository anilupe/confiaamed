using Confiamed.Application.Business;
using Microsoft.AspNetCore.Mvc;

namespace Confiamed.Forms.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController:ControllerBase
    {
        private readonly FormApplication _formApplication;

        public FormController(FormApplication formApplication)
        {
                _formApplication = formApplication;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await  _formApplication.Get();

            return Ok(data);
        }


    }
}
