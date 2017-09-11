using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PayloadFilter.Models;

namespace PayloadFilter.Controllers
{
    [Route("api/[controller]")]
    public class PayloadController : Controller
    {
        private IPayloadRepository _repository;
        private ILogger<PayloadController> _logger;

        public PayloadController(IPayloadRepository repository,
            ILogger<PayloadController> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        [HttpPost("")]
        public IActionResult Post([FromBody]Payloads payload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var payloadList = _repository.GetFilteredPayload(payload);
                    var result = new { response = payloadList };
                    _logger.LogError("Successfully retrieve the result");
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to retrieve: {0}", ex);
            }
            return BadRequest(new { error = "Could not decode request: JSON parsing failed" });
        }
    }
}
