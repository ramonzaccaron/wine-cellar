using Microsoft.AspNetCore.Mvc;
using WineCellar.Domain;
using WineCellar.Domain.Enums;

namespace WineCellar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BottleController : ControllerBase
    {
        private readonly ILogger<BottleController> _logger;

        public BottleController(ILogger<BottleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Bottle> GetAll()
        {
            _logger.LogInformation("Getting request and returning all list of wine bottles.");

            return new List<Bottle>()
            {
                new Bottle("Baron Philippe de Rothschild", 2021, Grape.CabernetSauvignon),
                new Bottle("Viña Carrasco D.O. Valle Central", 2022, Grape.Merlot),
                new Bottle("Pueblo del Sol Reserva", 2021, Grape.Chardonnay),
                new Bottle("Partridge Reserva", 2019, Grape.PinotNoir)
            };
        }
    }
}
