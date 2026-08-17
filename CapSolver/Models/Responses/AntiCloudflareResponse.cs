using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class AntiCloudflareResponse : ITaskResponse
{
    [JsonProperty("cookies")]
    public Dictionary<string, string>? Cookies { get; set; }

    [JsonProperty("token")]
    public string? Token { get; set; }

    [JsonProperty("userAgent")]
    public string? UserAgent { get; set; }
}
