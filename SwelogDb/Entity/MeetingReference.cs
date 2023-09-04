using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingReference
{
    public string MeetingReferenceId { get; set; } = null!;

    public string? Description { get; set; }
}
