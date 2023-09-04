using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgReportDetail
{
    public string ReportParaId { get; set; } = null!;

    public string? ResourceNo { get; set; }

    public short? WorkTicketCopies { get; set; }

    public string? WorkTicketPrintoption { get; set; }

    public short? ControlTicketCopies { get; set; }

    public string? ControlTicketPrintoption { get; set; }

    public short? MeasurementProtocolCopies { get; set; }

    public string? MeasurementProtPrintoption { get; set; }

    public short? ToolRequisitionCopies { get; set; }

    public string? ToolRequisitionPrintoption { get; set; }

    public short? MaterialRequisitionCopies { get; set; }

    public string? MaterialReqPrintoption { get; set; }

    public string? MaterialRequisitionBarcode { get; set; }

    public short? CutlistCopies { get; set; }

    public string? CutlistPrintoption { get; set; }

    public string? AuditStamp { get; set; }

    public string? WorkTicketBarcodeFlag { get; set; }

    public short? WorkCardCopies { get; set; }

    public string? WorkOpticketBarcodeFlag { get; set; }

    public string ProductionGroupId { get; set; } = null!;

    public string? FlagSortMatlOnStore { get; set; }

    public string? MatReqPgbrk { get; set; }

    public string? MatreqInToolreqYn { get; set; }

    public string? ToolInWorkcardYn { get; set; }

    public string? ReqLongItemTextYn { get; set; }

    public string? OpcontrolYn { get; set; }
}
