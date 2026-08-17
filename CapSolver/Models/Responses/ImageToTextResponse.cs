using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class ImageToTextResponse : ITaskResponse
{
    [JsonRequired]
    [JsonProperty("text")]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Only for the "number" module.
    /// </summary>
    [JsonProperty("answers")]
    public IList<string>? Answers { get; set; }
}