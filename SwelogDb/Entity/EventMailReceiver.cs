using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EventMailReceiver
{
    public string EventId { get; set; } = null!;

    public string ParameterValue { get; set; } = null!;

    public string? MailAddress { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? CopyMailAddress { get; set; }
}
