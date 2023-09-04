using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwViaForwardDelnoteLine
{
    public string MessageId { get; set; } = null!;

    public string DelnoteLineId { get; set; } = null!;

    public string Byarticleno { get; set; } = null!;

    public string Orderno { get; set; } = null!;
}
