using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task type is used to solve the Cloudflare Challenge page ("Just a moment...").
/// This task type requires proxy.
/// </summary>
public class AntiCloudflareTask : ITask, IProxyTask, IUserAgentTask
{
    [JsonProperty("type")]
    private static string Type => "AntiCloudflareTask";

    /// <summary>
    /// The address of the target page.
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    /// <summary>
    /// The user-agent you used to request the target website. Only Chrome's userAgent is supported.
    /// </summary>
    [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
    public string? UserAgent { get; set; }

    /// <summary>
    /// The response of requesting the target website, it usually contains "Just a moment..." and status code is 403.
    /// Needed for some websites, please be sure to use your sticky proxy to dynamically scrape the HTML every time.
    /// </summary>
    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; }

    /// <summary>
    /// Prepare an AntiCloudflareTask task.
    /// </summary>
    /// <param name="websiteUrl">The address of the target page.</param>
    /// <param name="userAgent">The user-agent you used to request the target website. Only Chrome's userAgent is supported.</param>
    /// <param name="html">The response of requesting the target website, needed for some websites.</param>
    public AntiCloudflareTask(string websiteUrl,
                              string? userAgent = null,
                              string? html = null)
    {
        WebsiteURL = websiteUrl;
        UserAgent = userAgent;
        Html = html;
    }
}
