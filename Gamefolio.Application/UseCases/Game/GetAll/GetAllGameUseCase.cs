using Gamefolio.Communication.Responses;

namespace Gamefolio.Application.UseCases.Game.GetAll;

public class GetAllGameUseCase
{
    public ResponseAllGameJson Execute()
    {
        return new ResponseAllGameJson
        {
            Games = new List<ResponseShortGameJson>
            {
                new ResponseShortGameJson
                {
                    Id = 1,
                    Name = "Beat Saber",
                    Type = Communication.Enums.GameType.Action
                }
            }
        };
    }
}
