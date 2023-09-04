using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Installation
{
    public int InstallationId { get; set; }

    public string? CustomerId { get; set; }

    public string? ReferenceId { get; set; }

    public string? Model { get; set; }

    public string? ProductName { get; set; }

    public string? ProductSerialNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Keyboard { get; set; }

    public string? FreeText { get; set; }

    public string? OurReferenceId { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? AuditStamp { get; set; }
}
