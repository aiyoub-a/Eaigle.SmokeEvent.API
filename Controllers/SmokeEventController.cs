using AutoMapper;
using Eaigle.SmokeEvent.API.Dto;
using Eaigle.SmokeEvent.API.Model;
using Eaigle.SmokeEvent.API.Repositories.Interfaces;
using Eaigle.SmokeEvent.API.SignalR.Hubs;
using Eaigle.SmokeEvent.API.SignalR.Hubs.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Eaigle.SmokeEvent.API.Controllers;


[ApiController]
[Route("[controller]")]
public class SomkeEventController : ControllerBase
{
    private readonly ILogger<SomkeEventController> _logger;
    private readonly IHubContext<HubClient, IHubClient> _hubContext;
    private readonly ISmokeEventRepository _repository;
    private readonly IMapper _mapper;

    public SomkeEventController(
        ILogger<SomkeEventController> logger, 
        IHubContext<HubClient, IHubClient> hubContext,
        ISmokeEventRepository repository,
        IMapper mapper)
    {
        _logger = logger;
        _hubContext = hubContext;
        _repository = repository;
        _mapper = mapper;
    }

    // POST api/smokeevent
    // [HttpPost]
    // [ProducesResponseType(StatusCodes.Status201Created)]
    // public void Post([FromBody] SmokeEventDto model)
    // {
    //     // Add smoke event to database then send message to clients
    //     _hubContext.Clients.All.SmokeIncident("Alert! A smoke has been detected");
    // }

    [HttpGet("id")]
    [ProducesResponseType(typeof(SmokeEventDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetSmokeEventById(int id)
    {
        var smokeEvent = _mapper.Map<SmokeEventDto>(await _repository.GetByIdAsync(id));
        return smokeEvent == null ? NotFound() : Ok(smokeEvent);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(SmokeEventDto smokeEvent)
    {
        // Add smoke event to database then send message to clients
        await _repository.AddAsync(_mapper.Map<TbSmokeEvent>(smokeEvent));

        // Send message to clients
        await _hubContext.Clients.All.SmokeIncident("Alert! A smoke has been detected");

        return CreatedAtAction(nameof(GetSmokeEventById), new { id = smokeEvent.Id }, smokeEvent);
    }
}