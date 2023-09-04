using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Cu170TempEcoEstimate
{
    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int RowNumber { get; set; }

    public string? Identifier { get; set; }

    public string? TextToDisplay { get; set; }

    public decimal? ValueForOne { get; set; }

    public decimal? ValueForLotsize { get; set; }

    public decimal? ValueForAnnreq { get; set; }

    public string? StockingUnit { get; set; }

    public string? UomFormat { get; set; }

    public string? TextForOne { get; set; }

    public string? TextForLotsize { get; set; }

    public string? TextForAnnreq { get; set; }

    public int? ColorRgb { get; set; }

    public decimal? ValueForAnnprognos { get; set; }

    public string? TextForAnnprognos { get; set; }

    public DateTime? CalcDate { get; set; }

    public string? BoldYn { get; set; }

    public string? Format { get; set; }

    public string? UnderlinedYn { get; set; }

    public string? AdditionalText { get; set; }
}
