using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TestApp.Helpers;
using TestApp.Models;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly ILogger<AddController> _logger;
        private readonly IAdditionHelper _additionHelper;
        private readonly TestAppContext dbContext;

        public AddController(ILogger<AddController> logger, IAdditionHelper additionHelper, TestAppContext dbContext)
        {
            _logger = logger;
            this._additionHelper = additionHelper;
            this.dbContext = dbContext;
        }

        [HttpPost(Name = "Add")]
        public async Task<int> Post(SummationRequest summation)
        {
            try
            {
                var result = _additionHelper.Add(summation.Num1, summation.Num2);
                Additon additon = new Additon
                {
                    Num1 = summation.Num1,
                    Num2 = summation.Num2,
                    Sum = result
                };
                dbContext.Add(additon);
                await dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}