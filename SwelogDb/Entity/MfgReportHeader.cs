using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgReportHeader
{
    public string ReportParaId { get; set; } = null!;

    public string? DeliveryTicketBarcodeFlag { get; set; }

    public short? DeliveryTicketCopies { get; set; }

    public string? DeliveryTicketPrintoption { get; set; }

    public string? PalletBarcodeFlag { get; set; }

    public short? PalletCopies { get; set; }

    public string? PalletPrintoption { get; set; }

    public short? NonStockCopies { get; set; }

    public string? NonStockPrintoption { get; set; }

    public string? FlagOpnTextInDelTicket { get; set; }

    public string? FlagSortMatlOnStore { get; set; }

    public string? AuditStamp { get; set; }

    public int? WorkCardCopies { get; set; }

    public string? WorkCardPrintoptions { get; set; }

    public string? WorkCardBarcodeFlag { get; set; }

    public int? ItemDrawingCopies { get; set; }

    public int? ItemPictureCopies { get; set; }

    public int? ItemDocumentCopies { get; set; }

    public int? OperationDrawingCopies { get; set; }

    public int? OperationPictureCopies { get; set; }

    public int? OperationDocumentCopies { get; set; }

    public string? ItemDrawingPrintoption { get; set; }

    public string? ItemPicturePrintoption { get; set; }

    public string? ItemDocumentPrintoption { get; set; }

    public string? OperationDrawingPrintoption { get; set; }

    public string? OperationPicturePrintoption { get; set; }

    public string? OperationDocumentPrintoption { get; set; }

    public string? WorkCardPrintoption { get; set; }

    public string? ItemDocumentHeader { get; set; }

    public string? OperationDocumentHeader { get; set; }

    public string? ParmkortBarcodeFlag { get; set; }

    public string? ParmkortCopies { get; set; }

    public string? ParmkortPrintoption { get; set; }

    public string? FlagOpnTextInParmkort { get; set; }

    public string? WorkcardWithReqYn { get; set; }

    public string? PalletParam { get; set; }

    public string? InspinstInWorkcardYn { get; set; }

    public string? ItemTextOnDelTicketYn { get; set; }
}
