using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Water_Jug_Challenge.Application.Contracts.Services;
using Water_Jug_Challenge.Application.Models;
using Water_Jug_Challenge.Domain;

namespace Water_Jug_Challenge.API.Controllers
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JugsController : ControllerBase
    {
        private readonly IgenericServices<JugsX> _ValorX;
        private readonly IgenericServices<JugsY> _ValorY;
        private readonly IgenericServices<JugsZ> _ValorZ;
        private readonly ISteps _steps;

        public JugsController(IgenericServices<JugsX> valorX, IgenericServices<JugsY> valorY, 
                              IgenericServices<JugsZ> valorZ, ISteps steps)
        {
            _ValorX = valorX;
            _ValorY = valorY;
            _ValorZ = valorZ;
            _steps = steps;
        }
        [HttpPost]
        public Task<ActionResult<bool> MostrarPasos([FromBody] JugsX justX, JugsY jugsY, JugsZ jugsZ, Stepsby step) 
        {
           
          

            return true;
        }



    }
}
