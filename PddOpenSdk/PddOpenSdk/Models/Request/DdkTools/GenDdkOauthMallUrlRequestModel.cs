using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.DdkTools
{
    public partial class GenDdkOauthMallUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 是否生成店铺收藏券推广链接
        /// </summary>
        [JsonProperty("generate_mall_collect_coupon")]
        public bool? GenerateMallCollectCoupon { get; set; }
        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        [JsonProperty("generate_qq_app")]
        public bool? GenerateQqApp { get; set; }
        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }
        /// <summary>
        /// 是否生成短链接，true-是，false-否
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// 是否生成唤起微信客户端链接，true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool? GenerateWeappWebview { get; set; }
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("mall_id")]
        public long MallId { get; set; }
        /// <summary>
        /// true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手
        /// </summary>
        [JsonProperty("multi_group")]
        public bool? MultiGroup { get; set; }
        /// <summary>
        /// 推广位
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

    }

}
