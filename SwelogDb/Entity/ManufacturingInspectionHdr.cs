using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturingInspectionHdr
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string? InspectionCode { get; set; }

    public decimal? InspectionQuantity { get; set; }

    public int? InspectionFrequency { get; set; }

    public string? DrawingNumber { get; set; }

    public string? RevisionNumber { get; set; }

    public short? NumberOfWorkTicket { get; set; }

    public string? ToolFlag { get; set; }

    public string? InspectionText { get; set; }

    public string? InspectionDesc { get; set; }

    public int? InspectionDescTxtid { get; set; }

    public string? InspectionDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? ControlTextCode { get; set; }

    public decimal? FirstInspectionQuantity { get; set; }

    public string? InspectionDocumentFlag { get; set; }

    public string? ChangeDescription { get; set; }

    public virtual ControlText? ControlTextCodeNavigation { get; set; }
}
