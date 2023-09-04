using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InstallationService
{
    public int InstallationId { get; set; }

    public int ServiceId { get; set; }

    public DateTime? ServiceDate { get; set; }

    public string? ReferenceId { get; set; }

    public string? Status { get; set; }

    public string? OurReferenceId { get; set; }

    public string? ServiceAction { get; set; }

    public string? ServiceDescription { get; set; }

    public string? ServiceComments { get; set; }

    public string? AuditStamp { get; set; }
}
