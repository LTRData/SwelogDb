using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmEvent
{
    public int EventSerialNumber { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? ExpectedTimeframe { get; set; }

    public short? StatusSerialNumber { get; set; }

    public string? ActionByUserId { get; set; }

    public short? PriorityCode { get; set; }

    public short? CrmEventType { get; set; }

    public int? EventValue { get; set; }
}
