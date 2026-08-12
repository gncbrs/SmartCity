namespace SmartCity.Domain;

public enum IncidentType
{
    TrafficAccident,
    RoadClosure,
    FireAlert,
    InfrastructureFailure,
    FloodAlert,
    PublicSafetyAlert,
    UtilityFailure
}

public enum IncidentPriority { Low, Medium, High, Critical }

public enum IncidentStatus { Open, Assigned, InProgress, Resolved, Closed }

public enum FieldUnitType { TrafficPolice, Ambulance, FireBrigade, Maintenance, PolicePatrol }

public enum FieldUnitStatus { Available, Assigned, Busy, Offline }

public enum OperationalTaskStatus { Pending, Assigned, InProgress, Completed, Cancelled }