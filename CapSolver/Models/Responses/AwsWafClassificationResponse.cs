using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class AwsWafClassificationResponse : ITaskResponse
{
    /// <summary>
    /// Present for grid-type questions: the image index that matches the question.
    /// </summary>
    [JsonProperty("objects")]
    public IList<int>? Objects { get; set; }

    /// <summary>
    /// Present for "toycarcity" questions: the point to place the dot at.
    /// </summary>
    [JsonProperty("box")]
    public IList<float>? Box { get; set; }

    /// <summary>
    /// Present when the question includes "bifurcatedzoo".
    /// </summary>
    [JsonProperty("distance")]
    public int? Distance { get; set; }
}
