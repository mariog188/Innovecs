using System;
using Innovecs.API.Controllers;
using Innovecs.API.Model.Request;
using Innovecs.API.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Innovecs.API.Model.Response;

namespace Innovecs.UnitTest.Controller
{
    public class CompanyControllerTest
    {
        private CompanyController companyController;
        public Mock<ICompanyService> mockCompanyService = new Mock<ICompanyService>();

        public CompanyControllerTest()
        {
            companyController = new CompanyController(mockCompanyService.Object);
        }

        [Fact]
        public async Task GetAmount()
        {
            mockCompanyService.Setup(mock => mock.GetAmountAsync(It.IsAny<CompanyAmountRequest>())).ReturnsAsync(12);
            var result = await companyController.GetAmount(new CompanyAmountRequest());  
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
        }

        [Fact]
        public async Task GetAmountNotFound()
        {
            mockCompanyService.Setup(mock => mock.GetAmountAsync(It.IsAny<CompanyAmountRequest>())).ThrowsAsync(new Exception());
            var result = await companyController.GetAmount(new CompanyAmountRequest());
           // var expected = new { Amount = 12 };
            Assert.IsType<NoContentResult>(result);
            Assert.Equal(204, (result as NoContentResult).StatusCode);
        }

        [Fact]
        public async Task GetTotal()
        {
            mockCompanyService.Setup(mock => mock.GetTotalAsync(It.IsAny<CompanyTotalRequest>())).ReturnsAsync(12);
            var result = await companyController.GetTotal(new CompanyTotalRequest());
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
        }

        [Fact]
        public async Task GetTotalNotFound()
        {
            mockCompanyService.Setup(mock => mock.GetTotalAsync(It.IsAny<CompanyTotalRequest>())).ThrowsAsync(new Exception());
            var result = await companyController.GetTotal(new CompanyTotalRequest());
            Assert.IsType<NoContentResult>(result);
            Assert.Equal(204, (result as NoContentResult).StatusCode);
        }

        [Fact]
        public async Task GetQuote()
        {
            mockCompanyService.Setup(mock => mock.GetQuoteAsync(It.IsAny<CompanyQuoteRequest>())).ReturnsAsync(12);
            var result = await companyController.GetQuote(new CompanyQuoteRequest());
            var expected = new QuoteResponse() { Quote = 12 };
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
            Assert.Equal(expected.Quote, ((result as OkObjectResult).Value as QuoteResponse).Quote);
        }

        [Fact]
        public async Task GetQuoteNotFound()
        {
            mockCompanyService.Setup(mock => mock.GetQuoteAsync(It.IsAny<CompanyQuoteRequest>())).ThrowsAsync(new Exception());
            var result = await companyController.GetQuote(new CompanyQuoteRequest());
            Assert.IsType<NoContentResult>(result);
            Assert.Equal(204, (result as NoContentResult).StatusCode);
        }
    }
}

