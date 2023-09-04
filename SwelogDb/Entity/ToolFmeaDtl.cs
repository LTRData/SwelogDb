using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolFmeaDtl
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? IssuedBy { get; set; }

    public DateTime? IssuedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? Participant { get; set; }

    public string? MeetingPoints { get; set; }

    public string? ProjectItemNumber { get; set; }

    public string? RevisionNo { get; set; }
}
