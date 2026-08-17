using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

public class AntiAwsWafTask : ITask, IProxyTask
{
    [JsonProperty("type")]
    private string Type => "AntiAwsWafTask";

    /// <summary>
    /// The URL of the page that returns the captcha info
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsContext is required
    /// </summary>
    [JsonProperty("awsKey", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsKey { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsIv is required
    /// </summary>
    [JsonProperty("awsIv", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsIv { get; set; }
  
    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsContext is required
    /// </summary>
    [JsonProperty("awsContext", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsContext { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405 or 202, awsChallengeJs is required
    /// </summary>
    [JsonProperty("awsChallengeJS", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsChallengeJS { get; set; }

    /// <summary>
    /// The jsapi.js link returned by the captcha page
    /// </summary>
    [JsonProperty("awsApiJs", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsApiJs { get; set; }

    /// <summary>
    /// The problem endpoint url containing keywords like problem, num_solutions_required, etc.
    /// </summary>
    [JsonProperty("awsProblemUrl", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsProblemUrl { get; set; }

    /// <summary>
    /// The api_key value of the problem endpoint
    /// </summary>
    [JsonProperty("awsApiKey", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsApiKey { get; set; }

    /// <summary>
    /// The aws-waf-token used for the last verification
    /// </summary>
    [JsonProperty("awsExistingToken", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsExistingToken { get; set; }

    /// <summary>
    /// </summary>
    /// <param name="websiteUrl">The URL of the page that returns the captcha info</param>
    /// <param name="awsKey">When the status code returned by the websiteURL page is 405, awsContext is required</param>
    /// <param name="awsIv">When the status code returned by the websiteURL page is 405, awsIv is required</param>
    /// <param name="awsContext">When the status code returned by the websiteURL page is 405, awsContext is required</param>
    /// <param name="awsChallengeJS">When the status code returned by the websiteURL page is 405 or 202, awsChallengeJs is required</param>
    /// <param name="awsApiJs">The jsapi.js link returned by the captcha page</param>
    /// <param name="awsProblemUrl">The problem endpoint url containing keywords like problem, num_solutions_required, etc.</param>
    /// <param name="awsApiKey">The api_key value of the problem endpoint</param>
    /// <param name="awsExistingToken">The aws-waf-token used for the last verification</param>
    public AntiAwsWafTask(string websiteUrl,
                          string? awsKey = null,
                          string? awsIv = null,
                          string? awsContext = null,
                          string? awsChallengeJS = null,
                          string? awsApiJs = null,
                          string? awsProblemUrl = null,
                          string? awsApiKey = null,
                          string? awsExistingToken = null)
    {
        WebsiteURL = websiteUrl;
        AwsKey = awsKey;
        AwsIv = awsIv;
        AwsContext = awsContext;
        AwsChallengeJS = awsChallengeJS;
        AwsApiJs = awsApiJs;
        AwsProblemUrl = awsProblemUrl;
        AwsApiKey = awsApiKey;
        AwsExistingToken = awsExistingToken;
    }
}
