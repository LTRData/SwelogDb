using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MpcResourceIdle
{
    public decimal KeyNo { get; set; }

    public decimal EventKeyNo { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? ActivityNo { get; set; }

    public string ActivityType { get; set; } = null!;

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public string EventId { get; set; } = null!;

    public string? InterruptCode { get; set; }
}
