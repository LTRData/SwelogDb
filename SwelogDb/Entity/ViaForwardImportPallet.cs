using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardImportPallet
{
    public int IdViaForwardImportPallet { get; set; }

    public int? IdViaForwardImportHdr { get; set; }

    public DateTime? ImportDate { get; set; }

    public decimal? XfrId { get; set; }

    public string? EdiOrderNo { get; set; }

    public string? EdiItemNo { get; set; }

    public string? EdiPalletNo { get; set; }

    public string? EdiDelnoteNo { get; set; }

    public decimal? PalletQty { get; set; }

    public string? SwelogPalletNo { get; set; }

    public string? ItemUnitFormat { get; set; }

    public decimal? AccumQty { get; set; }
}
