using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ClearanceHeader
{
    public int ClearanceNumber { get; set; }

    public DateTime? ClearanceDate { get; set; }

    public decimal? AgentFee { get; set; }

    public decimal? ClearanceFee { get; set; }

    public decimal? ImportPercentage { get; set; }

    public decimal? ConsPercentage { get; set; }

    public decimal? VatPercentage { get; set; }

    public string? Moved { get; set; }

    public string? AuditStamp { get; set; }
}
