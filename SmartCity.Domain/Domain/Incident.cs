

namespace SmartCity.Domain;

public class Incident
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string IncidentCode { get; set; } = default!;
    public IncidentType Type { get; set; }
    public IncidentPriority Priority { get; set; }
    public IncidentStatus Status { get; set; } = IncidentStatus.Open;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Description { get; set; }
    public DateTime ReportedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<OperationalTask> Tasks { get; set; } = new List<OperationalTask>();
}