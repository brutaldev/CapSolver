using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class ReCaptchaV2Response : ITaskResponse
{
    [JsonRequired]
    [JsonProperty("gRecaptchaResponse")]
    public string GReCaptchaResponse { get; set; } = null!;

    [JsonProperty("userAgent")]
    public string UserAgent { get; set; } = null!;

    [JsonProperty("expireTime")]
    public long ExpireTime { get; set; }

    [JsonProperty("secChUa")]
    public string? SecChUa { get; set; }

    [JsonProperty("createTime")]
    public long? CreateTime { get; set; }

    /// <summary>
    /// Returned when isSession is enabled on a v3 task. Used as a cookie.
    /// </summary>
    [JsonProperty("recaptcha-ca-t")]
    public string? RecaptchaCaT { get; set; }

    /// <summary>
    /// Automatically returned by some v2 websites. Used as a cookie.
    /// </summary>
    [JsonProperty("recaptcha-ca-e")]
    public string? RecaptchaCaE { get; set; }
}