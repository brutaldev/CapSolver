using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

public class ReCaptchaV2ClassificationTask : ITask
{
    [JsonProperty("type")]
    private static string Type => "ReCaptchaV2Classification";

    /// <summary>
    /// Base64-encoded image, do not include "data:image/***;base64,"
    /// </summary>
    [JsonRequired]
    [JsonProperty("image")]
    public string Image { get; set; }

    /// <summary>
    /// For full names of questions, please refer to the following list of questions.
    /// <br />
    /// See supported types: <seealso href="https://docs.capsolver.com/en/guide/recognition/ReCaptchaClassification/">click here</seealso>
    /// </summary>
    [JsonProperty("question", NullValueHandling = NullValueHandling.Include)]
    public string Question { get; set; }

    /// <summary>
    /// Page source url to improve accuracy
    /// </summary>
    [JsonProperty("websiteURL", NullValueHandling = NullValueHandling.Ignore)]
    public string? WebsiteUrl { get; set; }

    /// <summary>
    /// Website key to improve accuracy
    /// </summary>
    [JsonProperty("websiteKey", NullValueHandling = NullValueHandling.Ignore)]
    public string? WebsiteKey { get; set; }

    /// <summary>
    /// Prepare a ReCaptchaV2Classification task.
    /// <br/>
    /// See supported types: <seealso href="https://docs.capsolver.com/en/guide/recognition/ReCaptchaClassification/">click here</seealso>
    /// </summary>
    /// <param name="image">Base64-encoded image, do not include "data:image/***;base64,"</param>
    /// <param name="question">For full names of questions, please refer to the following list of questions.</param>
    /// <param name="websiteUrl">Page source url to improve accuracy</param>
    /// <param name="websiteKey">Website key to improve accuracy</param>
    public ReCaptchaV2ClassificationTask(string image, string question, string? websiteUrl = null, string? websiteKey = null)
    {
        Image = image;
        Question = question;
        WebsiteUrl = websiteUrl;
        WebsiteKey = websiteKey;
    }
}
