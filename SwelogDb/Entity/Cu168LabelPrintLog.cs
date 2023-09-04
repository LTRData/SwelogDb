using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu168LabelPrintLog
{
    public int LogId { get; set; }

    public string? UserId { get; set; }

    public DateTime? PrintDate { get; set; }

    public string? WorkstationId { get; set; }

    public string? FunctionId { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? ControlId { get; set; }

    public int? PalletNumber { get; set; }

    public int? LabelCount { get; set; }

    public int? TransportPackageLabelCount { get; set; }

    public string? LabelLanguageCode { get; set; }

    public string? DataLanguageCode { get; set; }

    public int? TemplateSerialNumber { get; set; }

    public int? PackageTemplateSerialNumber { get; set; }
}
