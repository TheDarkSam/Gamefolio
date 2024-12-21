using Gamefolio.Communication.Responses;

namespace Gamefolio.Application.UseCases.Game.GetById;

public class GetGameByIdUseCase
{
    public ResponseGameJson Execute(int id)
    {
        return new ResponseGameJson
        {
            Id = id,
            LaunchDate = new DateTime(year: 2018, month: 01, day: 01),
            Name = "Beat Saber",
            Type = Communication.Enums.GameType.Action
        };
    }
}
