using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task type is used to solve the reCaptchaV2 version
/// </summary>
public class ReCaptchaV2Task : ITask, IUserAgentTask, ICookieTask, IProxyTask
{
    [JsonProperty("type")]
    private string Type => "ReCaptchaV2Task";

    /// <summary>
    /// Address of a webpage with Google ReCaptcha
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteUrl { get; set; }

    /// <summary>
    /// Recaptcha website key. <div class="g-recaptcha" data-sitekey="THAT_ONE"></div>
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteKey")]
    public string WebsiteKey { get; set; }

    /// <summary>
    /// Specify whether or not Recaptcha is invisible.
    /// </summary>
    [JsonProperty("isInvisible", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInvisible { get; set; }

    /// <summary>
    /// Browser's User-Agent which is used in emulation. It is required that you use a signature of a modern browser, otherwise Google will ask you to "update your browser".
    /// </summary>
    [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
    public string? UserAgent { get; set; }

    /// <summary>
    /// Additional cookies which we must use during interaction with target page or Google.
    /// </summary>
    [JsonProperty("cookies", NullValueHandling = NullValueHandling.Ignore)]
    public string? Cookies { get; set; }

    /// <summary>
    /// For ReCaptchaV2, if there is an "sa" parameter in the payload of the /anchor endpoint, submit its value.
    /// </summary>
    [JsonProperty("pageAction", NullValueHandling = NullValueHandling.Ignore)]
    public string? PageAction { get; set; }

    /// <summary>
    /// For ReCaptchaV2 normal version, if there is an "s" parameter in the payload of the /anchor endpoint, submit its value.
    /// </summary>
    [JsonProperty("recaptchaDataSValue", NullValueHandling = NullValueHandling.Ignore)]
    public string? RecaptchaDataSValue { get; set; }

    /// <summary>
    /// Some implementations of the reCAPTCHA widget may contain additional parameters
    /// that are passed to the "grecaptcha.enterprise.render" method along with the sitekey.
    /// </summary>
    [JsonProperty("enterprisePayload", NullValueHandling = NullValueHandling.Ignore)]
    public object? EnterprisePayload { get; set; }

    /// <summary>
    /// The domain name for loading the captcha. Usually this parameter does not need to be passed.
    /// </summary>
    [JsonProperty("apiDomain", NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiDomain { get; set; }

    /// <summary>
    /// Prepare a ReCaptchaV2 task
    /// </summary>
    /// <param name="websiteUrl">Address of a webpage with Google ReCaptcha</param>
    /// <param name="websiteKey">Recaptcha website key. <div class="g-recaptcha" data-sitekey="THAT_ONE"></div></param>
    /// <param name="isInvisible">Specify whether or not Recaptcha is invisible.</param>
    /// <param name="userAgent">Browser's User-Agent which is used in emulation.</param>
    /// <param name="cookies">Additional cookies which we must use during interaction with target page or Google.</param>
    /// <param name="pageAction">If there is an "sa" parameter in the payload of the /anchor endpoint, submit its value.</param>
    /// <param name="recaptchaDataSValue">If there is an "s" parameter in the payload of the /anchor endpoint, submit its value.</param>
    /// <param name="enterprisePayload">Additional parameters passed to the "grecaptcha.enterprise.render" method along with the sitekey.</param>
    /// <param name="apiDomain">The domain name for loading the captcha.</param>
    public ReCaptchaV2Task(string websiteUrl,
                           string websiteKey,
                           bool? isInvisible = null,
                           string? userAgent = null,
                           string? cookies = null,
                           string? pageAction = null,
                           string? recaptchaDataSValue = null,
                           object? enterprisePayload = null,
                           string? apiDomain = null)
    {
        WebsiteUrl = websiteUrl;
        WebsiteKey = websiteKey;
        IsInvisible = isInvisible;
        UserAgent = userAgent;
        Cookies = cookies;
        PageAction = pageAction;
        RecaptchaDataSValue = recaptchaDataSValue;
        EnterprisePayload = enterprisePayload;
        ApiDomain = apiDomain;
    }
}