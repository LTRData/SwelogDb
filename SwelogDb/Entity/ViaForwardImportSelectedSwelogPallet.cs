using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardImportSelectedSwelogPallet
{
    public int IdViaForwardImportSelectedSwelogPallets { get; set; }

    public DateTime? ImportDate { get; set; }

    public string? SwelogPalletNo { get; set; }

    public string? SwelogItemNo { get; set; }

    public int? SwelogLotNo { get; set; }

    public int? SwelogOpNo { get; set; }

    public int? ActivityNo { get; set; }

    public decimal? PalletQty { get; set; }

    public decimal? AccumQty { get; set; }

    public string? GoodsentryNo { get; set; }

    public int? IdViaForwardImportHdr { get; set; }

    public int? XfrId { get; set; }
}
