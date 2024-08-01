using Microsoft.AspNetCore.Mvc;
using TradeCategoryUbsAPI.Models;
using TradeCategoryUbsAPI.Services;

namespace TradeCategoryUbsAPI.Controllers
{
  [ApiController]
[Route("api/[controller]")]
public class TradeController : ControllerBase
    {
        private readonly CategorizeTradesService _categorizeTradesService;

        public TradeController(CategorizeTradesService categorizetrades)
        {
                _categorizeTradesService = categorizetrades ?? throw new ArgumentNullException(nameof(categorizetrades));
        }

        [HttpPost("categorize")]
        public ActionResult<List<string>> CategorizeTrades([FromBody] List<Trade> trades)
        {
            if (trades == null || trades.Count == 0)
                return BadRequest("Trade list is empty.");

            var categories = _categorizeTradesService.CategorizeTrades(trades);
            return Ok(categories);
        }
    }

}

