

namespace SmartCity.Domain;

public class FieldUnit
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UnitCode { get; set; } = default!;
    public string Name { get; set; } = default!;
    public FieldUnitType Type { get; set; }
    public FieldUnitStatus Status { get; set; } = FieldUnitStatus.Available;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<OperationalTask> Tasks { get; set; } = new List<OperationalTask>();
    public ICollection<UnitPositionHistory> PositionHistory { get; set; } = new List<UnitPositionHistory>();
}