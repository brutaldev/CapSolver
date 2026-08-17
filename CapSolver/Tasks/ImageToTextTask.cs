using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task type is used to recognize image captchas.
/// </summary>
public class ImageToTextTask : ITask
{
    /// <summary>
    /// Task's type.
    /// </summary>
    [JsonProperty("type")]
    private static string Type => "ImageToTextTask";

    /// <summary>
    /// Page source url to improve accuracy
    /// </summary>
    [JsonProperty("websiteURL")]
    public string? WebsiteUrl { get; set; }

    /// <summary>
    /// Base64 encoded content of the image (no newlines, no data:image/***;charset=utf-8;base64,)
    /// </summary>
    [JsonProperty("body")]
    public string Body { get; set; }

    /// <summary>
    /// Only for the "number" module. Support up to 9 base64 encoded images each time.
    /// </summary>
    [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// Specifies the module.
    /// <br />
    /// See independent module support list: <seealso href="https://docs.capsolver.com/en/guide/recognition/ImageToTextTask/">click here</seealso>
    /// </summary>
    [JsonProperty("module")]
    public string? Module { get; set; }

    /// <summary>
    /// Identify the matching degree. If the recognition rate is not within the range, no deduction
    /// </summary>
    /// <value>0.8 ~ 1</value>
    [JsonProperty("score")]
    public float? Score { get; set; }

    /// <summary>
    /// Prepare an image to text task.
    /// </summary>
    /// <param name="body">Base64 encoded content of the image (without line breaks)</param>
    /// <param name="images">Only for the "number" module. Support up to 9 base64 encoded images each time.</param>
    public ImageToTextTask(string body, string? module = null, float? score = null, IList<string>? images = null)
    {
        Body = body;
        Module = module;
        Score = score;
        Images = images;
    }
}