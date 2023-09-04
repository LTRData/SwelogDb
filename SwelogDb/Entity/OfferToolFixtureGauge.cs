using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferToolFixtureGauge
{
    public int SimulationLotNumber { get; set; }

    public string OperationList { get; set; } = null!;

    public int OperationNumber { get; set; }

    public string ToolNumber { get; set; } = null!;

    public string? ToolType { get; set; }

    public string? ToolDescription { get; set; }

    public int? ToolPrice { get; set; }

    public int? ToolDescriptionTxtid { get; set; }

    public string? AuditStamp { get; set; }

    public virtual OfferOperationDtl OfferOperationDtl { get; set; } = null!;
}
