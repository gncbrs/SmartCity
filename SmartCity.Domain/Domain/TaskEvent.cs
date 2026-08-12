namespace SmartCity.Domain;

public class TaskEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid TaskId { get; set; }
    public OperationalTask Task { get; set; } = default!;

    public OperationalTaskStatus FromStatus { get; set; }
    public OperationalTaskStatus ToStatus { get; set; }
    public string? Note { get; set; }
    public DateTime OccurredAt { get; set; } = DateTime.UtcNow;
}