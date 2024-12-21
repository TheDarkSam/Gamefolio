using Gamefolio.Communication.Enums;

namespace Gamefolio.Communication.Responses;

public class ResponseShortGameJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public GameType Type { get; set; }
}
