using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotIt.AutoPicker.Persistance.Data.Epicor;
using DotIt.AutoPicker.Service;
using log4net;
using Newtonsoft.Json;

namespace DotIt.AutoPicker.Models
{
	public class EpicorServiceApi : IEpicorserviceApi
	{
		public ILog Log { get; set; }
		public ApiResponse _apiResponse { get; set; }
		public IList<PickedOrders> GetPickedOrderList()
		{
			throw new NotImplementedException();
		}

		public IList<OrderDtl> GetPendingPickOrderList()
		{
			// Log.Logger.Log( "GetWebOrder");

			try
			{
				using (_apiResponse = new ApiResponse())
				{//  DLog.Log("Calling Epicor api :" + Constant.EpicorApi_SalesOrder);
					var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "Get");
					if (!_response.success)
					{
						//DLog.Log("Epicor api failed  " + Constant.EpicorApi_SalesOrder);
						return null;
					}

					var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
					if (_data.ContainsKey("value"))
					{

						if (!String.IsNullOrEmpty(_data["value"].ToString()))
						{
							var _result = JsonConvert.DeserializeObject<List<OrderDtl>>(_data["value"].ToString());
							//  DLog.Log("Epicor api return records  " + _result.Count);
							return _result;
						}

					}

					// DLog.Log("Epicor api return no record");
					return null;
				}
			}
			catch (Exception ex)
			{
				// DLog.Log("Exception in GetWebOrder : " + ex.Message);
				return null;
			}
		}

		public IList<OrderHed> GetOrderHead()
		{
			// Log.Logger.Log( "GetWebOrder");

			try
			{
				using (_apiResponse = new ApiResponse())
				{//  DLog.Log("Calling Epicor api :" + Constant.EpicorApi_SalesOrder);
					var _response = _apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "Get");
					if (!_response.success)
					{
						//DLog.Log("Epicor api failed  " + Constant.EpicorApi_SalesOrder);
						return null;
					}

					var _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(_response.Response);
					if (_data.ContainsKey("value"))
					{

						if (!String.IsNullOrEmpty(_data["value"].ToString()))
						{
							var _result = JsonConvert.DeserializeObject<List<OrderHed>>(_data["value"].ToString());
							//  DLog.Log("Epicor api return records  " + _result.Count);
							return _result;
						}

					}

					// DLog.Log("Epicor api return no record");
					return null;
				}

			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
