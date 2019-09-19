using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.Epicor;
using DotIt.AutoPickerApi.Data.UnitOfWork;
using DotIt.AutoPickerApi.Models;
using DotIt.AutoPickerApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dotit.AutoPicker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DotitExtensionContext _DotitExtensionContext;
        ERP102TestContext _EpicorContext;
        IDotitService _DotitService;
        IEpicorServiceApi _EpicorServiceApi;
        IUnitOfWork _UnitOfWork;

        public OrderController(DotitExtensionContext dotitExtensionContext, ERP102TestContext epicorContext, IDotitService dotitService, IEpicorServiceApi epicorServiceApi, IUnitOfWork unitOfWork)
        {
            _DotitExtensionContext = dotitExtensionContext;
            _EpicorContext = epicorContext;
            _DotitService = dotitService;
            _EpicorServiceApi = epicorServiceApi;
            _UnitOfWork = unitOfWork;
        }



       // GET: api/Order
       [HttpGet("{dcdUserId}")]
        public async Task<ActionResult<ResponseModel>> Get(string dcdUserId)
        {
            var picker = await _DotitService.GetDotitPickersAsync(dcdUserId);
            var result = await _DotitService.AssignOrderToPickerAsync(picker.FirstOrDefault());
            if (result)
            { return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Success, "Assign Order to picker ", dcdUserId) }; }
            return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed, "Some issue found in Assigning Order,", "Contact Administrator") };
        }

        // GET: api/Order
        [HttpGet("{UserId}",Name ="Assign")]
        public async Task<ActionResult<ResponseModel>> GetOrder(string UserId)
        {
            var result = await _DotitService.GetDotitPickerOrdersAsync(UserId);

            if (result != null || result.Count() > 0)
            { return new ResponseModel() { Success = true, Response = JsonConvert.SerializeObject(result) }; }
            return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed, "Some issue found in Getting assigned order,", "Contact Administrator") };
        }






        // GET: api/Order/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
