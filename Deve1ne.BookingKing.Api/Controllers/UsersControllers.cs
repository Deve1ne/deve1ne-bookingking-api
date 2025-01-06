using Deve1ne.BookingKing.Application.Dtos.BandSide;
using Deve1ne.BookingKing.Application.Features.Users.Commands;
using Deve1ne.BookingKing.Application.Features.Users.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace Deve1ne.BookingKing.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(Summary = "Create a user", Description = "Command used to create a user")]
    [SwaggerRequestExample(typeof(CreateUserCommand), typeof(CreateUserCommand))]
    [SwaggerResponseExample(StatusCodes.Status201Created, typeof(CreateUserCommand))]

    public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(Summary = "Get a user", Description = "Command used to get a user")]
    public async Task<IActionResult> GetUser([FromRoute] string id)
    {
        var query = new GetUserQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(Summary = "Delete a user", Description = "Command used to delete a user")]
    public async Task<IActionResult> DeleteUser([FromRoute] string id)
    {
        var command = new DeleteUserCommand();
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(Summary = "Update a user", Description = "Command used to update a user")]
    [SwaggerRequestExample(typeof(UpdateUserCommand), typeof(UpdateUserCommand))]
    [SwaggerResponseExample(StatusCodes.Status201Created, typeof(UpdateUserCommand))]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}