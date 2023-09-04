using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EventMailEvent
{
    public string EventId { get; set; } = null!;

    public int? EventDescription { get; set; }

    public int? ParameterDescription { get; set; }
}
