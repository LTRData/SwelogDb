using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardImportXfr
{
    public int IdViaForwardImportXfr { get; set; }

    public DateTime? ImportDate { get; set; }

    public decimal? XfrId { get; set; }
}
