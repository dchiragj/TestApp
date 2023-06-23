using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TestApp.Helpers;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly ILogger<AddController> _logger;
        private readonly IAdditionHelper _additionHelper;

        public AddController(ILogger<AddController> logger, IAdditionHelper additionHelper)
        {
            _logger = logger;
            this._additionHelper = additionHelper;
        }

        [HttpPost(Name = "Add")]
        public async Task<int> Post(SummationRequest summation)
        {
            return _additionHelper.Add(summation.Num1,summation.Num2);
        }
    }
}