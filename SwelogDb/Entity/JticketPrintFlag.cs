using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class JticketPrintFlag
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string? DeliveryTicketPrintFlag { get; set; }

    public string? PalletLabelPrintFlag { get; set; }

    public string? WorkCardPrintFlag { get; set; }

    public string? NonStockPrintFlag { get; set; }

    public string? ItemDrawingPrintFlag { get; set; }

    public string? ItemPicturePrintFlag { get; set; }

    public string? ItemDocumentPrintFlag { get; set; }

    public string? DeviationFlag { get; set; }

    public int? DeviationTxtid { get; set; }

    public int? DeviationRepBy { get; set; }

    public DateTime? DeviationRepDate { get; set; }

    public DateTime? DeviationReviewDate { get; set; }

    public string? MatpunktPrintFlag { get; set; }
}
