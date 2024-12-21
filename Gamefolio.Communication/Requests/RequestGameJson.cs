using Gamefolio.Communication.Enums;

namespace Gamefolio.Communication.Requests;

public class RequestGameJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime LaunchDate { get; set; }
    public GameType GameType { get; set; }
}
