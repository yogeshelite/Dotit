using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotIt.AutoPickerApi.Data.UnitOfWork;
using DotIt.AutoPickerApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.Epicor;
using DotIt.AutoPickerApi.Models;
using Newtonsoft.Json;

namespace Dotit.AutoPicker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickerController : ControllerBase
    {
        private readonly DotitExtensionContext _DotitExtensionContext;
        ERP102TestContext _EpicorContext;
        IDotitService _DotitService;
        IEpicorServiceApi _EpicorServiceApi;
        IUnitOfWork _UnitOfWork;

        public PickerController(DotitExtensionContext dotitExtensionContext, ERP102TestContext epicorContext, IDotitService dotitService , IEpicorServiceApi epicorServiceApi, IUnitOfWork unitOfWork)
        {
            _DotitExtensionContext = dotitExtensionContext;
            _EpicorContext = epicorContext;
            _DotitService = dotitService;
            _EpicorServiceApi = epicorServiceApi;
            _UnitOfWork = unitOfWork;
        }

        // GET: api/Picker
        [HttpGet("{dcdUserID}")]
        public async Task <ActionResult< ResponseModel>> Get( string dcdUserID)
        {
            var result =  await _DotitService.GetDotitPickersAsync(dcdUserID);
            if (result != null || result.Count() > 0)
            { return new ResponseModel() { Success = true, Response = JsonConvert.SerializeObject(result.FirstOrDefault()) }; }
            return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed,"Profile","Not Found") };
        }

        // GET: api/Picker
        [HttpGet]
        public async Task<ActionResult<ResponseModel>> Get()
        {
            var result = await _DotitService.GetDotitPickersAsync(string.Empty);
            if (result != null || result.Count() > 0)
            { return new ResponseModel() { Success = true, Response = JsonConvert.SerializeObject(result) }; }
            return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed, "Pickers", "Not Found") };
        }

        // POST: api/Picker
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Picker/5
        [HttpPut("{dcdUserID}")]
        public async Task<ResponseModel> Put(string dcdUserID,[FromBody] RequestModel resuest)
        {
            PickerModel picker = JsonConvert.DeserializeObject<PickerModel>(resuest.Data);
            picker.DcdUserID = dcdUserID;
            var result = await _DotitService.UpdateProfileAsync(picker);
            if (result)
            {
                var data = await _DotitService.GetDotitPickersAsync(picker.DcdUserID);
                return new ResponseModel() { Success = true, Response = JsonConvert.SerializeObject(data.FirstOrDefault()) };
            }
            return new ResponseModel() { Success = true, Response = string.Format(Constant.Message.Failed, "Profile", "Not Found") };
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
