using Api.Domain.Dtos.Patient;
using Api.Domain.Interfaces;
using Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PaitentsController(IPatientsService patientsService) : ControllerBase
{
    [SwaggerOperation(Summary = "Get Paitent by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetPaitentDto>>> Get(int id, CancellationToken cancellationToken = default)
    {
        var result = await patientsService.GetPaitentAsync(id, cancellationToken);
        if (result == null)
            return NotFound("Employee not found");
        return new ApiResponse<GetPaitentDto>
        {
            Data = result,
            Success = true
        };
    }

    [SwaggerOperation(Summary = "Get all Paitents")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<IList<GetPaitentDto>>>> GetAll(CancellationToken cancellationToken = default)
    {
        var result = await patientsService.GetPaitentsAsync(cancellationToken);
        return new ApiResponse<IList<GetPaitentDto>>
        {
            Data = result,
            Success = true
        };
    }
    
    [SwaggerOperation(Summary = "Create Paitent")]
    [HttpPost("")]
    public async Task<ActionResult<ApiResponse<GetPaitentDto>>> Create([FromBody]GetPaitentDto request, CancellationToken cancellationToken = default)
    {
        if (request == null)
            return BadRequest();
        if (!request.Medications.Any())
            return BadRequest();
        var result = await patientsService.CreatePatientAsync(request, cancellationToken);
        return new ApiResponse<GetPaitentDto>
        {
            Data = result,
            Success = true
        };
    }
}
