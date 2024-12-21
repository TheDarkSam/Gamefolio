using Gamefolio.Communication.Enums;

namespace Gamefolio.Communication.Responses;

public class ResponseRegisteredGameJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public GameType Type { get; set; }
    public DateTime LaunchDate { get; set; }
}
