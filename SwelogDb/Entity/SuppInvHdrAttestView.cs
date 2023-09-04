using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvHdrAttestView
{
    public string CompanyNo { get; set; } = null!;

    public string? AttestCode { get; set; }

    public string? ArrivalSeriesNo { get; set; }
}
