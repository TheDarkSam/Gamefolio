using Gamefolio.Application.UseCases.Game.Delete;
using Gamefolio.Application.UseCases.Game.GetAll;
using Gamefolio.Application.UseCases.Game.GetById;
using Gamefolio.Application.UseCases.Game.Register;
using Gamefolio.Application.UseCases.Game.Update;
using Gamefolio.Communication.Requests;
using Gamefolio.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Gamefolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredGameJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestGameJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update(int id, [FromBody] RequestGameJson request)
    {
        new UpdateGameUseCase().Execute(id, request);
        
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllGameJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllGameUseCase().Execute();

        if (response.Games.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGameJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var response = new GetGameByIdUseCase().Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteGameByIdUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
