using Gamefolio.Communication.Requests;
using Gamefolio.Communication.Responses;

namespace Gamefolio.Application.UseCases.Game.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredGameJson Execute(RequestGameJson request)
    {
        return new ResponseRegisteredGameJson
        {
            Id = 3,
            Name = request.Name,
        }; 
    }
}
