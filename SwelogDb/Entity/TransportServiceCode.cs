using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransportServiceCode
{
    public string TransportModeCode { get; set; } = null!;

    public string TransportServiceCode1 { get; set; } = null!;

    public string? TransportServiceCodeDescription { get; set; }

    public double? TransportServiceCodeDescTxtid { get; set; }

    public string? TransportServiceCodeDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? PaidCustomerReturnYn { get; set; }
}
