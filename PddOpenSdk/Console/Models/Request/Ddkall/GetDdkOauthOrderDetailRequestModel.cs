using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Ddkall
{
public partial class GetDdkOauthOrderDetailRequestModel : PddRequestModel
{
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public string OrderSn {get;set;}

}

}
