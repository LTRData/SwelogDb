using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderType
{
    public string MfgOrderTypeCode { get; set; } = null!;

    public string? MfgOrderTypeText { get; set; }

    public string? ReportParaId { get; set; }
}
