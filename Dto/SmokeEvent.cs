namespace Eaigle.SmokeEvent.API.Dto;

public class SmokeEventDto
{
    public int Id { get; set; }

    public int FacilityId { get; set; }

    public DateTime DateTimeStart { get; set; }
    
    public DateTime DateTimeStop { get; set; }
    
    public string? Description { get; set; }
    
    public int TakenByProcessId { get; set; }

    public bool AlertEmailSMSSent { get; set; }
}

