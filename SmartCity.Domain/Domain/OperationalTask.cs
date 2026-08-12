

namespace SmartCity.Domain;

public class OperationalTask
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string TaskCode { get; set; } = default!;

    public Guid IncidentId { get; set; }
    public Incident Incident { get; set; } = default!;

    public Guid? FieldUnitId { get; set; }
    public FieldUnit? FieldUnit { get; set; }

    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public OperationalTaskStatus Status { get; set; } = OperationalTaskStatus.Pending;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? AssignedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TaskEvent> Events { get; set; } = new List<TaskEvent>();
}