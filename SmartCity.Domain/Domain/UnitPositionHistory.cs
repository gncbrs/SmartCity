namespace SmartCity.Domain;

public class UnitPositionHistory
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FieldUnitId { get; set; }
    public FieldUnit FieldUnit { get; set; } = default!;

    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime RecordedAt { get; set; } = DateTime.UtcNow;
}