using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class VisionEngineClassificationResponse : ITaskResponse
{
    /// <summary>
    /// Present for slider-type modules.
    /// </summary>
    [JsonProperty("distance")]
    public int? Distance { get; set; }

    /// <summary>
    /// Present for rotate-type modules.
    /// </summary>
    [JsonProperty("angle")]
    public int? Angle { get; set; }

    [JsonProperty("box")]
    public IList<float>? Box { get; set; }

    /// <summary>
    /// Present for the "botdeflector" module: a list of [x, y] points.
    /// </summary>
    [JsonProperty("points")]
    public IList<IList<int>>? Points { get; set; }
}