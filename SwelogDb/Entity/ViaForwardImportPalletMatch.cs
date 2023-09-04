using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardImportPalletMatch
{
    public int IdViaForwardImportPalletMatch { get; set; }

    public DateTime? ImportDate { get; set; }

    public int? XfrId { get; set; }

    public int? IdViaForwardImportHdr { get; set; }

    public int? IdViaForwardImportPallet { get; set; }

    public int? IdViaForwardImportSelectedSwelogPallets { get; set; }

    public decimal? PalletQty { get; set; }

    public decimal? AccumQty { get; set; }
}
