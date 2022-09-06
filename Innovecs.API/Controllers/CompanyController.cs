using System.Threading.Tasks;
using Innovecs.API.Model.Request;
using Innovecs.API.Model.Response;
using Innovecs.API.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Innovecs.API.Controllers
{
    public class CompanyController : Controller
    {
        public readonly ICompanyService _companyService;


        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTotal([FromBody] CompanyTotalRequest companyTotalRequest)
        {
            try
            {
                var result = await _companyService.GetTotalAsync(companyTotalRequest);
                return new OkObjectResult(new { Total = result });
            }
            catch
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAmount([FromBody] CompanyAmountRequest companyAmountRequest)
        {
            try
            {
                var result = await _companyService.GetAmountAsync(companyAmountRequest);
                return new OkObjectResult( new { Amount = result });
            }
            catch
            {
                return new NoContentResult();
            }

        }

        [Consumes("application/xml")]
        [Produces("application/xml")]
        [HttpGet]
        public async Task<IActionResult> GetQuote([FromBody] CompanyQuoteRequest companyQuoteRequest)
        {
            try
            {
                var result = await _companyService.GetQuoteAsync(companyQuoteRequest);
                
                return new OkObjectResult(new QuoteResponse() { Quote = result});
            }
            catch
            {
                return new NoContentResult();
            }
        }
    }
}

